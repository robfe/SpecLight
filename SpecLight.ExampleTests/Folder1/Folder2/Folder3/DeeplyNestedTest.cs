using Xunit;

namespace SpecLight.ExampleTests.Folder1.Folder2.Folder3
{
    [Trait("category", "examples")]
    public class DeeplyNestedTest
    {

        [Fact]
        public void ATest()
        {
            new Spec(@"
This is just an example of how deep namespaces get collapsed in the output HTML,
instead of having three folders there's just the one with dots between the names")
                .Execute();
        }

    }

}
