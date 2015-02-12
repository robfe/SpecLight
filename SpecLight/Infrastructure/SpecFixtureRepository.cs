using System;

namespace SpecLight.Infrastructure
{
    internal static class SpecFixtureRepository<T> where T : ISpecFixture, new()
    {
        static SpecFixtureRepository()
        {
            Fixture = new T();
            Fixture.GlobalSetup();
            AppDomain.CurrentDomain.DomainUnload += (sender, args) => Fixture.GlobalTeardown();
        }

        public static readonly T Fixture;
    }
}
