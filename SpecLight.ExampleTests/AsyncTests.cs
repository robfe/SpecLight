using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SpecLight.ExampleTests
{
    [Trait("category", "examples")]
    public class AsyncTests
    {
        [Fact]
        public Task Async()
        {
            return new Spec(@"
Speclight can be used to execute async methods, chaining the Task awaiting all the way up to the test framework")
                .WithFixture<ExecutionTimer>()
                .Tag("async")
                .GivenAsync(ICallAnAsyncMethod)
                .WhenAsync(ICallAnotherAsyncMethodThatWaitsFor_Msec, 15)
                .Then(ICanStillCallASynchronousMethod)
                .ExecuteAsync();
        }

        [Fact]
        public void AsyncWarnsIfYouDontCallAsync()
        {
            new Spec(@"Testing frameworks like to be given a Task if you're using them, so Speclight will warn you (with Obsolete) if you call Execute on a spec that's used an async step")
                .WithFixture<ExecutionTimer>()
                .Tag("async")
                .GivenAsync(ICallAnAsyncMethod)
                .WhenAsync(ICallAnotherAsyncMethodThatWaitsFor_Msec, 15)
                .Then(ICanStillCallASynchronousMethod)
                .Execute(); //heed this warning
        }

        async Task ICallAnAsyncMethod()
        {
            Console.Out.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(5);
            Console.Out.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        Task ICallAnotherAsyncMethodThatWaitsFor_Msec(int msec)
        {
            Console.Out.WriteLine(Thread.CurrentThread.ManagedThreadId);
            return Task.Delay(msec);
        }

        void ICanStillCallASynchronousMethod()
        {
            Console.Out.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
