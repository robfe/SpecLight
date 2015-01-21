using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SpecLight.ExampleTests
{
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
