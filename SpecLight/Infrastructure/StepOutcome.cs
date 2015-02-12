using System;

namespace SpecLight.Infrastructure
{
    internal class StepOutcome
    {
        public Step Step { get; set; }
        public Status Status { get; set; }
        public Exception Error { get; set; }

        /// <summary>
        /// Was the passing method actually empty
        /// </summary>
        public bool Empty { get; set; }
    }
}
