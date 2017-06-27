using System;
#if NETCOREAPP1_1
using System.Runtime.Loader;
#endif

namespace SpecLight.Infrastructure
{
    internal static class SpecFixtureRepository<T> where T : ISpecFixture, new()
    {
        static SpecFixtureRepository()
        {
            Fixture = new T();
            Fixture.GlobalSetup();
#if NETCOREAPP1_1
            AssemblyLoadContext.Default.Unloading += context => Fixture.GlobalTeardown();
#else
            AppDomain.CurrentDomain.DomainUnload += (sender, args) => Fixture.GlobalTeardown();
#endif
        }

        public static readonly T Fixture;
    }
}
