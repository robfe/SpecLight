using System;
using System.Runtime.CompilerServices;
using Xunit;
using Xunit.Extensions;

namespace SpecLight.ExampleTests.Folder1.Folder2
{
    [Trait("category", "examples")]
    public class ExampleTests
    {

        [Fact]
        public void Empty()
        {
            new Spec(@"
                    Sometimes you just want to write a step, and have it pass even though it does nothing
					Speclight detects method that have no code and adds 'empty' to the status of 'passed'")
                .Given(EmptyMethodWithArgument_, "x")
                .When(IPressAdd)
                .Then(EmptyMethodWithArgument_, "x")
                .Execute();
        }

        void IPressAdd()
        {
        }

	    void EmptyMethodWithArgument_(string arg)
	    {
		    
	    }

    }

}