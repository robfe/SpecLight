using Xunit;

namespace SpecLight.Tests
{
    public class StringHelpersTests
    {
        [Fact]
        public void ValuesAreOneWord()
        {
            Assert.Equal("the US is one word", StringHelpers.CreateText("The_IsOneWord", "US"));
        }

        [Fact]
        public void ShouldTrueGetsReplaced()
        {
            Assert.Equal("shan't", StringHelpers.CreateText("Shall_", false));
            Assert.Equal("I shouldn't see the light", StringHelpers.CreateText("IShould_SeeTheLight", false));
        }
    }
}