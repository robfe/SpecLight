using System;
using System.Collections.Generic;

namespace SpecLight
{
    public class Step
    {
        static readonly List<string> SkipExceptions = new List<string>("NUnit.Framework.InconclusiveException".Split(','));

        public Step()
        {
            Tags = new List<string>();
        }

        public ScenarioBlock Type { get; set; }
        public string Description { get; set; }
        public Action Action { get; set; }
        public List<string> Tags { get; private set; }

        internal string FormattedType
        {
            get { return (Type == ScenarioBlock.And ? "  " : "") + Type; }
        }

        public StepOutcome Execute(bool shouldSkip)
        {
            var outcome = new StepOutcome {Step = this};
            if (shouldSkip)
            {
                outcome.Status = Status.Skipped;
                return outcome;
            }

            try
            {
                Action();
                outcome.Status = Status.Passed;
            }
            catch (NotImplementedException e)
            {
                outcome.Status = Status.Pending;
                outcome.Error = e;
            }
            catch (Exception e)
            {
                outcome.Status = SkipExceptions.Contains(e.GetType().FullName) ? Status.Skipped : Status.Failed;
                outcome.Error = e;
            }
            return outcome;
        }
    }
}