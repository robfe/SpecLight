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
        readonly ExpandoObject _extraData = new ExpandoObject();

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
        public dynamic DataBag { get { return _extraData; }}

        /// <summary>
        /// A dictionary to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataBag"/>. Any contents of type string will be printed to output.
        /// </summary>
        public IDictionary<string, object> DataDictionary { get { return _extraData; }}

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


        internal async Task<StepOutcome> ExecuteAsync()
        {
            var outcome = new StepOutcome {Step = this};
            if (WillBeSkipped)
            {
                outcome.Status = Status.Skipped;
                return outcome;
            }

            try
            {
                await AsyncAction();
                outcome.Status = Status.Passed;
                outcome.Empty = Reflector.MethodIsEmpty(OriginalDelegate.GetMethodInfo());
            }
            catch (NotImplementedException e)
            {
                outcome.Status = Status.Pending;
                outcome.Error = e;
                outcome.ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(e);
            }
            catch (Exception e)
            {
                outcome.Status = Reflector.SkipExceptionNames.Contains(e.GetType().FullName) ? Status.Skipped : Status.Failed;
                outcome.Error = e;
                outcome.ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(e);
            }
           

            return outcome;
        }

        internal StepOutcome Execute()
        {
            var outcome = new StepOutcome {Step = this};
            if (WillBeSkipped)
            {
                outcome.Status = Status.Skipped;
                return outcome;
            }

            try
            {
                SynchronousAction();
                outcome.Status = Status.Passed;
                outcome.Empty = Reflector.MethodIsEmpty(OriginalDelegate.GetMethodInfo());
            }
            catch (NotImplementedException e)
            {
                outcome.Status = Status.Pending;
                outcome.Error = e;
                outcome.ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(e);
            }
            catch (Exception e)
            {
                outcome.Status = Reflector.SkipExceptionNames.Contains(e.GetType().FullName) ? Status.Skipped : Status.Failed;
                outcome.Error = e;
                outcome.ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(e);
            }
           

            return outcome;
        }
    }
}
