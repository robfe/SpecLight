namespace SpecLight
{
    public interface ISpecFixture
    {
        void GlobalSetup();
        void GlobalTeardown();
        void SpecSetup(Spec spec);
        void SpecTeardown(Spec spec);
        void StepSetup(Step step);
        void StepTeardown(Step step);
    }
}