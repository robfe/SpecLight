using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Xunit;
using Xunit.Extensions;

namespace SpecLight.ExampleTests
{
    [Trait("category", "examples")]
    public class ExampleTests
    {
        int total;

        [Fact]
        public void Pending()
        {
            new Spec(@"
                    In order to know how much money I can save
                    As a Math Idiot
                    I want to add two numbers").Tag("Pending")
                .Given(IEnter_, 5)
                .And(IEnter_, 6)
                .When(IPressAddPending).Tag("NotImplemented")
                .Then(TheResultShouldBe_, 11)
                .Execute();
        }

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

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, -2, -1)]
        [InlineData(1, 2, 35)]
        public void Theory(int i1, int i2, int sum)
        {
            new Spec(@"
                    In order to know how much money I can save
                    As a Math Idiot
                    I want to add two numbers").Tag("Money")
                .Given(IEnter_, i1)
                .And(IEnter_, i2)
                .When(IPressAdd)
                .Then(TheResultShouldBe_, sum)
                .Execute(string.Format("Theory: {0}+{1}={2}", i1, i2, sum));
        }

        [Fact]
        public void Failing()
        {
            new Spec(@"
                    In order to know how much money I can save
                    As a Math Idiot
                    I want to add two numbers")
                .Tag("DemonstrateFinally")
                .WithFixture<ExecutionTimer>()
                .Given(IEnter_, 5)
                .Finally(() => Console.WriteLine("Cleanup 1/2"))
                .And(IEnter_, 6)
                .When(IPressAdd)
                .Then(TheResultShouldBe_, -12013)
                .Finally(() => Console.WriteLine("Cleanup 2/2"))
                .Execute();
        }


        void IPressAdd()
        {
        }

        void TheResultShouldBe_(int obj)
        {
            Assert.Equal(obj, total);
        }

        void IPressAddPending()
        {
            throw new NotImplementedException();
        }

        void EmptyMethodWithArgument_(string arg)
        {

        }

        void IEnter_(int obj)
        {
            total += obj;
        }
    }

    public class ExecutionTimer : SpecFixtureBase
    {
        public override void StepSetup(Step step)
        {
            //since this class is time-sensitive, access the dictionary not the bag. Warmup can be as high as 200ms for dynamic invokes.
            step.DataDictionary["Timer"] = Stopwatch.StartNew(); //this won't get printed as it's not a string.
        }

        public override void StepTeardown(Step step)
        {
            var stopwatch = (Stopwatch)step.DataDictionary["Timer"];
            stopwatch.Stop();
            step.DataBag.ExecutionTime = stopwatch.ElapsedMilliseconds + "ms"; //this goes into the output as it's a string

            if (stopwatch.ElapsedMilliseconds > 10)
            {
                step.Tags.Add("slow");
            }
        }

        public override void SpecTeardown(Spec spec)
        {
            //note that the spec would have actually taken a lot longer to execute (speclight reflection overhead), but the following number is accurate for user code
            var total = spec.Steps.Select(x => (Stopwatch)x.DataBag.Timer).Sum(x => x.ElapsedMilliseconds);
            spec.DataBag.ExecutionTime = total + "ms";
        }
    }
}
