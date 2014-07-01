using System;
using Xunit;
using Xunit.Extensions;

namespace SpecLight.Tests
{
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
                .Given(IEnter_, 5)
                .And(IEnter_, 6)
                .When(IPressAdd).Tag("NotImplemented")
                .Then(TheResultShouldBe_, -12013)
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

        void IEnter_(int obj)
        {
            total += obj;
        }
    }
}