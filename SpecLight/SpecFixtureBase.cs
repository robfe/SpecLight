namespace SpecLight
{
    public class SpecFixtureBase : ISpecFixture
    {
        public virtual void GlobalSetup()
        {
        }

        public virtual void GlobalTeardown()
        {
        }

        public virtual void SpecSetup(Spec spec)
        {
        }

        public virtual void SpecTeardown(Spec spec)
        {
        }

        public virtual void StepSetup(Step step)
        {
        }

        public virtual void StepTeardown(Step step)
        {
        }
    }
}