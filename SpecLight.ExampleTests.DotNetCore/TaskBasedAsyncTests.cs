using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SpecLight.ExampleTests.DotNetCore
{
    [Trait("category", "examples")]
    [Description(@"
# Async support

[SpecLight](https://github.com/robfe/speclight) can be used to create async tests.

Calling `(Given/When/Then/And)Async` lets you return a Task from your step method, which SpecLight will wait for before calling the next step

Then you should `ExecuteAsync` the Spec instead of simply calling `Execute`, so that you can pass the parent task up to your test framework.
")]
    [Collection(SpecReporterCollectionDefinition.Name)]
    public class TaskBasedAsyncTests
    {
        [Fact]
        public Task Async()
        {
            //return a task
            return new Spec(@"
SpecLight can be used to execute async methods, chaining the Task awaiting all the way up to the test framework")
                .WithFixture<ExecutionTimer>()
                .Tag("async")
                .GivenAsync(ICallAnAsyncMethod)
                .WhenAsync(ICallAnotherAsyncMethodThatWaitsFor_Msec, 15)
                .Then(ICanStillCallASynchronousMethod)
                .ExecuteAsync();
        }

        [Fact]
        public async Task AwaitableAsync()
        {
            //await a task
            await new Spec(@"
It's up to you whether you `await` the call to `ExecuteAsync()` or return it directly")
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
            new Spec(@"Testing frameworks like to be given a Task if you're using them, so SpecLight will warn you (with Obsolete) if you call Execute on a spec that's used an async step")
                .WithFixture<ExecutionTimer>()
                .Tag("async")
                .GivenAsync(ICallAnAsyncMethod)
                .WhenAsync(ICallAnotherAsyncMethodThatWaitsFor_Msec, 15)
                .Then(ICanStillCallASynchronousMethod)
                .Execute(); //heed this warning
        }

        [Fact]
        public Task AsyncFailure()
        {
            //return a task
            return new Spec(@"
SpecLight can be used to execute async methods, chaining the Task awaiting all the way up to the test framework")
                .WithFixture<ExecutionTimer>()
                .Tag("async")
                .GivenAsync(ICallAnAsyncMethod)
                .WhenAsync(ICallAnotherAsyncMethodThatWaitsFor_Msec, 15)
                .ThenAsync(ICallAFailingAsyncMethod)
                .ExecuteAsync();
        }

        Task ICallAFailingAsyncMethod()
        {
//            throw new Exception();
            return Task.Factory.StartNew(() => { throw new Exception(); });
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
