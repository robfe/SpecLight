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
	}
}