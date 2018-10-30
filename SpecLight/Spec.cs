using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using SpecLight.Infrastructure;

namespace SpecLight
{
    /// <summary>
    /// A Spec is the core of Speclight. Construct it with some descriptive text (In order to / as a / I want) then use the Given/When/Then/And step methods. Then call Execute or ExecuteAsync to actually run the spec's steps.
    /// </summary>
    public partial class Spec : IAsyncSpec
    {
        Action finalActions;

        readonly ExpandoObject extraData = new ExpandoObject();
        Dictionary<Lazy<Exception>, Step> caughtExceptionReferences = new Dictionary<Lazy<Exception>, Step>();

        public Spec(string description, Action<string> writeLine = null)
        {
            //delete any leading whitespace from each line in description
            Description = Regex.Replace(description.Trim(), @"^\s+", "", RegexOptions.Multiline);
            WriteLine = writeLine ?? Console.WriteLine;
        }

        public string Description { get; private set; }
        public MethodBase CallingMethod { get; set; }
        public string TestMethodNameOverride { get; set; }
        public List<Step> Steps { get; private set; } = new List<Step>();

        /// <summary>
        /// Set this if you need to control where output is printed to. Default is Console.WriteLine
        /// </summary>
        public Action<string> WriteLine { get; set; }

        /// <summary>
        /// A bag to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataDictionary"/>. Any contents of type string will be printed to output.
        /// </summary>
        public dynamic DataBag => extraData;

        /// <summary>
        /// A dictionary to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataBag"/>. Any contents of type string will be printed to output.
        /// </summary>
        public IDictionary<string, object> DataDictionary => extraData;


        internal List<StepOutcome> Outcomes { get; private set; } = new List<StepOutcome>();
        internal List<string> SpecTags { get; private set; } = new List<string>();
        internal List<ISpecFixture> Fixtures { get; private set; } = new List<ISpecFixture>();

        void AddStep(ScenarioBlock block, string text, Func<Task> asyncAction, Action synchronousAction, Delegate originalDelegate, object[] arguments)
        {
            if (Reflector.NameIsCompilerGenerated(originalDelegate.Method.Name) || Reflector.NameIsCompilerGenerated(originalDelegate.Method.DeclaringType?.Name))
            {
                throw new ArgumentException(@"Don't call speclight step methods with delegates/lambdas, it can't produce a human-friendly description from those.
If you want to pass arguments to steps, just call the overloaded methods that take steps:

    .And(()=>IEnterTheUsername(""Bob""))

becomes

    .And(IEnterTheUsername, ""Bob"")

");
            }

            Steps.Add(new Step
            {
                Type = block,
                Description = text,
                AsyncAction = asyncAction,
                SynchronousAction = synchronousAction,
                OriginalDelegate = originalDelegate,
                Index = Steps.Count,
                Arguments = arguments,
                Spec = this
            });
        }

        public Spec Tag(params string[] tags)
        {
            var step = Steps.LastOrDefault();
            var list = step == null ? SpecTags : step.Tags;
            list.AddRange(tags);
            return this;
        }
        /// <summary>
        ///     If a step is supposed to throw an exception, you can use Catch to store that exception. If the step would have failed, it will now pass.
        ///     If the step actually passed but it should have thrown an exception, it will continue to pass. It's up to you to write a subsequent step that inspects
        ///     the exception stored in the Lazy. Luckily, if you forget, this Spec will fail despite all steps "passing"
        /// </summary>
        /// <param name="caughtExceptionReference">A reference to a field you can store the exception in, for reading by other steps</param>
        public Spec Catch(out Lazy<Exception> caughtExceptionReference)
        {
            Exception caughtException = null;
            var step = Steps.Last();

            step.catchException = e => caughtException = e;
            caughtExceptionReference = new Lazy<Exception>(() => caughtException);
            caughtExceptionReferences[caughtExceptionReference] = step;

            return this;
        }

        public Spec Finally(IDisposable disposable)
        {
            return Finally(disposable.Dispose);
        }

        public Spec Finally(Action finalAction)
        {
            finalActions += finalAction;
            return this;
        }

        public Spec WithFixture<T>() where T : ISpecFixture, new()
        {
            Fixtures.Add(SpecFixtureRepository<T>.Fixture);
            return this;
        }







        /// <summary>
        ///     Run the spec, printing its results to the output windows, and re-throwing the first exception that it encountered
        ///     (such as an Assert failure)
        ///     Be sure to call Execute from your unit test method directly so that it can detect its calling method correctly
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Execute([CallerMemberName] string testMethodNameOverride = null)
        {
            CallingMethod = CallingMethod ?? Reflector.FindCallingMethod();
            TestMethodNameOverride = testMethodNameOverride;
            if (Steps.Any(x => x.SynchronousAction == null))
            {
                //not ideal, user should have called ExecuteAsync, but we can still go ahead
                RunOutcomesAsync().Wait();
            }
            else
            {
                RunOutcomes();
                CleanupAndThrowIfFailed();
            }

        }

        /// <summary>
        ///     Run the spec async, printing its results to the output windows, and re-throwing the first exception that it encountered
        ///     (such as an Assert failure)
        ///     Be sure to call Execute from your unit test method directly so that it can detect its calling method correctly
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public async Task ExecuteAsync([CallerMemberName] string testMethodNameOverride = null)
        {
            CallingMethod = CallingMethod ?? Reflector.FindCallingMethod();
            TestMethodNameOverride = testMethodNameOverride;
            await RunOutcomesAsync();
            CleanupAndThrowIfFailed();
        }

        void CleanupAndThrowIfFailed()
        {
            finalActions?.Invoke();
            SpecReporter.Add(this);
            ConsoleOutcomePrinter.PrintOutcomes(this, WriteLine);

            //rethrow the first error if any
            var thrower = Outcomes.Select(x => x.ExceptionDispatchInfo).FirstOrDefault(x => x != null);
            thrower?.Throw();

            //check if there were any un-inspected exception references
            var unInspectedExceptionReference = caughtExceptionReferences
                .Where(x => !x.Key.IsValueCreated)
                .Select(x => x.Value)
                .FirstOrDefault();

            if (unInspectedExceptionReference != null)
            {
                throw new Exception($"Error was thrown by step \'{unInspectedExceptionReference.Description}\', but was not inspected");
            }
        }

        async Task RunOutcomesAsync()
        {
            Fixtures.ForEach(x => x.SpecSetup(this));
            var skip = false;
            foreach (var step in Steps)
            {
                step.WillBeSkipped = skip;
                Fixtures.ForEach(x => x.StepSetup(step));
                var o = await step.ExecuteAsync();
                Outcomes.Add(o);
                skip = skip || o.CausesSkip;
                Fixtures.ForEach(x => x.StepTeardown(step));
            }
            Fixtures.ForEach(x => x.SpecTeardown(this));
        }

        void RunOutcomes()
        {
            Fixtures.ForEach(x => x.SpecSetup(this));
            var skip = false;
            foreach (var step in Steps)
            {
                step.WillBeSkipped = skip;
                Fixtures.ForEach(x => x.StepSetup(step));
                var o = step.Execute();
                Outcomes.Add(o);
                skip = skip || o.CausesSkip;
                Fixtures.ForEach(x => x.StepTeardown(step));
            }
            Fixtures.ForEach(x => x.SpecTeardown(this));
        }

        public static IReadOnlyList<string> WriteSpecReports()
        {
            return SpecReporter.WriteSpecs();
        }
    }
}
