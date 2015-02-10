using System;
using System.Threading.Tasks;
using PowerAssert;
using Xunit;

namespace SpecLight.Tests
{
    public class ReflectionTests
    {
        [Fact]
        public async Task AsyncMethodFindsRightTestClass()
        {
            var spec = new Spec("");
            await spec.ExecuteAsync();
            PAssert.IsTrue(() => spec.CallingMethod.DeclaringType == typeof(ReflectionTests));
            PAssert.IsTrue(() => spec.CallingMethod.Name == "AsyncMethodFindsRightTestClass");
        }

        [Fact]
        public void NormalMethodFindsRightTestClass()
        {
            var spec = new Spec("");
            spec.ExecuteAsync().Wait();
            PAssert.IsTrue(() => spec.CallingMethod.DeclaringType == typeof(ReflectionTests));
            PAssert.IsTrue(() => spec.CallingMethod.Name == "NormalMethodFindsRightTestClass");
        }

        [Fact]
        public void AddingADelegateStepThrowsAnException()
        {
            var spec = new Spec("");
            try
            {
                //can't use Assert.Throws here as that would introduce an extra lambda
                spec.And(() => Foo("x"));
            }
            catch (ArgumentException e)
            {
                return; //pass
            }
            throw new Exception("Expected method to throw exception");
        }

        void Foo(string s)
        {
            
        }
    }
}
