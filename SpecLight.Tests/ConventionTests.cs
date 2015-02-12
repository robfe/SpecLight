using System.Linq;
using PowerAssert;
using Xunit;

namespace SpecLight.Tests
{
    public class ConventionTests
    {
        [Fact]
        public void AllInfrastructureClassesAreInternal()
        {
            var exportedTypes = typeof(Spec).Assembly.GetExportedTypes();
            var bad = exportedTypes.Where(x => x.Namespace.EndsWith("Infrastructure"));
            PAssert.IsTrue(() => !bad.Any());

        }
    }
}
