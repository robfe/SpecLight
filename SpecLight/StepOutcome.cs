using System;

namespace SpecLight
{
    public class StepOutcome
    {
        public Step Step { get; set; }
        public Status Status { get; set; }
        public Exception Error { get; set; }
    }
}