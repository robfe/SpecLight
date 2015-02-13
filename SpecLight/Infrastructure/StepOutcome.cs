using System;
using System.Runtime.ExceptionServices;

namespace SpecLight.Infrastructure
{
    internal class StepOutcome
    {
        public StepOutcome(Step step)
        {
            Step = step;
        }

        public Step Step { get; private set; }
        public Status Status { get; set; }
        public Exception Error { get; set; }
        public ExceptionDispatchInfo ExceptionDispatchInfo { get; set; }

        /// <summary>
        /// Was the passing method actually devoid of code?
        /// </summary>
        public bool Empty { get; set; }

        /// <summary>
        /// Should we start skipping steps now?
        /// </summary>
        public bool CausesSkip { get { return Status == Status.Failed || Status == Status.Pending; } }

    }
}
