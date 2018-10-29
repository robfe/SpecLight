using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using SpecLight.Infrastructure;

namespace SpecLight
{
    public class Step
    {
        readonly ExpandoObject extraData = new ExpandoObject();
        Func<Exception, bool> expectException;

        public ScenarioBlock Type { get; internal set; }
        public string Description { get; internal set; }
        public List<string> Tags { get; private set; } = new List<string>();
        public object[] Arguments { get; internal set; }
        public Spec Spec { get; internal set; }
        public int Index { get; internal set; }
        public bool WillBeSkipped { get; internal set; }


        /// <summary>
        /// A bag to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataDictionary"/>. Any contents of type string will be printed to output.
        /// </summary>
        public dynamic DataBag => extraData;

        /// <summary>
        /// A dictionary to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataBag"/>. Any contents of type string will be printed to output.
        /// </summary>
        public IDictionary<string, object> DataDictionary => extraData;

        /// <summary>
        /// Runs this step asynchronously - can't be null
        /// </summary>
        internal Func<Task> AsyncAction { get; set; }

        /// <summary>
        /// Runs this step synchronously - will be null if the original delegate did not have a return type of task. The intention is that if any of the steps are missing this then the whole spec has to be run asynchronously.
        /// </summary>
        internal Action SynchronousAction { get; set; }

        internal Delegate OriginalDelegate { get; set; }


        internal string FormattedType => Type.ToString().PadLeft(5, ' ');

        public void WhichShouldThrow<T>(Func<T,bool> exceptionInspector = null) where T : Exception
        {
            if (this.expectException != null)
            {
                throw new ArgumentException("Can't call WhichShouldThrow more than once per step");
            }
            Description += ", which should throw an " + typeof(T).Name;
            expectException = e => e is T ee && (exceptionInspector == null || exceptionInspector(ee));
        }

        internal Task<StepOutcome> ExecuteAsync()
        {
            if (WillBeSkipped)
            {
                return Task.FromResult(Skip());
            }

            try
            {
                return AsyncAction().ContinueWith<StepOutcome>(task => !task.IsFaulted ? PassUnlessExceptionExpected() : ErrorUnlessExceptionExpected(Unwrap(task.Exception)));
            }
            catch (Exception e)
            {
                return Task.FromResult(ErrorUnlessExceptionExpected(e));
            }
        }

        Exception Unwrap(AggregateException exception)
        {
            return exception.InnerExceptions.Count == 1 ? exception.InnerException : exception;
        }

        internal StepOutcome Execute()
        {
            if (WillBeSkipped)
            {
               return Skip();
            }

            try
            {
                SynchronousAction();
                return PassUnlessExceptionExpected();
            }
            catch (Exception e)
            {
                return ErrorUnlessExceptionExpected(e);
            }
        }

        StepOutcome PassUnlessExceptionExpected()
        {
            if (expectException != null)
            {
                return Error(new Exception("Expected Exception was not thrown by step"));
            }
            return Pass();
        }

        StepOutcome Pass()
        {
            return new StepOutcome(this)
            {
                Status = Status.Passed,
                Empty = Reflector.MethodIsEmpty(OriginalDelegate.GetMethodInfo())
            };
        }

        StepOutcome Skip()
        {
            return new StepOutcome(this)
            {
                Status = Status.Skipped
            };
        }

        StepOutcome ErrorUnlessExceptionExpected(Exception e)
        {
            if (expectException != null && expectException(e))
            {
                return Pass();
            }
            return Error(e);
        }

        StepOutcome Error(Exception e)
        {
            return new StepOutcome(this)
            {
                Error = e,
                ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(e),
                Status = Reflector.PendingExceptionNames.Contains(e.GetType().FullName) ? Status.Pending : Status.Failed
            };
        }

    }
}
