using System;
using Xunit;

namespace SpecLight.ExampleTests.DotNetCore
{
    [CollectionDefinition(Name)]
    public class SpecReporterCollectionDefinition : ICollectionFixture<SpecReporterCollectionDefinition.SpecReporterFixture>
    {
        public const string Name = "Spec Reporter";

        public class SpecReporterFixture : IDisposable
        {
            public void Dispose()
            {
                Spec.WriteSpecReports();
            }
        }
    }
}
