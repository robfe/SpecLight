using System;

namespace SpecLight.Infrastructure
{
    public class PrintCurrentStepFixture : SpecFixtureBase
    {
        public override void StepSetup(Step step)
        {
            Console.WriteLine("> SpecLight {2} step: {0} {1}", step.Type, step.Description, step.WillBeSkipped ? "skipping" : "executing");
        }
    }
}
