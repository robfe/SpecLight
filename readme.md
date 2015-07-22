SpecLight is a simple BDD framework for C#

Look at the Tests project for examples:

		[Fact]
		public void Passing()
		{
			new Spec(@"
					In order to know how much money I can save
					As a Math Idiot
					I want to add two numbers").Tag("Money")
				.Given(IEnter_, 5)
				.And(IEnter_, 6)
				.When(IPressAdd)
				.Then(TheResultShouldBe_, 11)
				.Execute();
		}


Once your tests have run, SpecLight generates an html report for you next to your test DLL called "Speclight.html"

There is a converter tool at http://robfe.github.io/SpecLight/converter
