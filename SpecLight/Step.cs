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

        public Step()
        {
            Tags = new List<string>();
        }

        public ScenarioBlock Type { get; internal set; }
        public string Description { get; internal set; }
        public List<string> Tags { get; private set; }
        public object[] Arguments { get; internal set; }
        public Spec Spec { get; internal set; }
        public int Index { get; internal set; }
        public bool WillBeSkipped { get; internal set; }


        /// <summary>
        /// A bag to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataDictionary"/>. Any contents of type string will be printed to output.
        /// </summary>
        public dynamic DataBag { get { return extraData; }}

        /// <summary>
        /// A dictionary to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataBag"/>. Any contents of type string will be printed to output.
        /// </summary>
        public IDictionary<string, object> DataDictionary { get { return extraData; }}

        /// <summary>
        /// Runs this step asynchronously - can't be null
        /// </summary>
        internal Func<Task> AsyncAction { get; set; }

        /// <summary>
        /// Runs this step synchronously - will be null if the original delegate did not have a return type of task. The intention is that if any of the steps are missing this then the whole spec has to be run asynchronously.
        /// </summary>
        internal Action SynchronousAction { get; set; }

        internal Delegate OriginalDelegate { get; set; }


        internal string FormattedType
        {
            get { return Type.ToString().PadLeft(5, ' '); }
        }


        internal Task<StepOutcome> ExecuteAsync()
        {
            if (WillBeSkipped)
            {
                return Task.FromResult(Skip());
            }

            try
            {
                return AsyncAction().ContinueWith<StepOutcome>(task => !task.IsFaulted ? Pass() : Error(Unwrap(task.Exception)));
            }
            catch (Exception e)
            {
                return Task.FromResult(Error(e));
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
                return Pass();
            }
            catch (Exception e)
            {
                return Error(e);
            }
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
