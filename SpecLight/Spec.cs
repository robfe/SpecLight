using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SpecLight.Infrastructure;

namespace SpecLight
{
    /// <summary>
    /// A Spec is the core of Speclight. Construct it with some descriptive text (In order to / as a / I want) then use the Given/When/Then/And step methods. Then call Execute or ExecuteAsync to actually run the spec's steps.
    /// </summary>
    public partial class Spec : IAsyncSpec
    {
        Action _finalActions;

        readonly ExpandoObject _extraData = new ExpandoObject();

        public Spec(string description, Action<string> writeLine = null)
        {
            //delete any leading whitespace from each line in description
            Description = Regex.Replace(description.Trim(), @"^\s+", "", RegexOptions.Multiline);
            Steps = new List<Step>();
            SpecTags = new List<string>();
            Fixtures = new List<ISpecFixture>();
            Outcomes = new List<StepOutcome>();
            WriteLine = writeLine ?? Console.WriteLine;

            //this fixture is added to all specs by default:
            WithFixture<PrintCurrentStepFixture>();
        }

        public string Description { get; private set; }
        public MethodBase CallingMethod { get; set; }
        public string TestMethodNameOverride { get; set; }
        public List<Step> Steps { get; private set; }

        /// <summary>
        /// Set this if you need to control where output is printed to. Default is Console.WriteLine
        /// </summary>
        public Action<string> WriteLine { get; set; }

        /// <summary>
        /// A bag to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataDictionary"/>. Any contents of type string will be printed to output.
        /// </summary>
        public dynamic DataBag { get { return _extraData; } }

        /// <summary>
        /// A dictionary to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataBag"/>. Any contents of type string will be printed to output.
        /// </summary>
        public IDictionary<string, object> DataDictionary { get { return _extraData; } }


        internal List<StepOutcome> Outcomes { get; private set; }
        internal List<string> SpecTags { get; private set; }
        internal List<ISpecFixture> Fixtures { get; private set; }

        void AddStep(ScenarioBlock block, string text, Func<Task> asyncAction, Action synchronousAction, Delegate originalDelegate, object[] arguments)
        {
            if (Reflector.NameIsCompilerGenerated(originalDelegate.Method.Name) || Reflector.NameIsCompilerGenerated(originalDelegate.Method.DeclaringType.Name))
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

        public Spec Finally(IDisposable disposable)
        {
            return Finally(disposable.Dispose);
        }

        public Spec Finally(Action finalAction)
        {
            _finalActions += finalAction;
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
            }
            var thrower = CleanupAndGetThrower();
            if (thrower != null)
            {
                thrower.Throw();
            }
        }

        /// <summary>
        ///     Run the spec async, printing its results to the output windows, and re-throwing the first exception that it encountered
        ///     (such as an Assert failure)
        ///     Be sure to call Execute from your unit test method directly so that it can detect its calling method correctly
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ExecuteAsync([CallerMemberName] string testMethodNameOverride = null)
        {
            CallingMethod = CallingMethod ?? Reflector.FindCallingMethod();
            TestMethodNameOverride = testMethodNameOverride;
            return RunOutcomesAsync().ContinueWith(ProcessOutcomes);
        }

        void ProcessOutcomes(Task t)
        {
            var thrower = CleanupAndGetThrower();
            if (thrower != null)
            {
                thrower.Throw();
            }
        }

        ExceptionDispatchInfo CleanupAndGetThrower()
        {
            if (_finalActions != null)
            {
                _finalActions();
            }
            SpecReporter.Add(this);
            ConsoleOutcomePrinter.PrintOutcomes(this, WriteLine);

            //rethrow the first error if any
            return Outcomes.Select(x => x.ExceptionDispatchInfo).FirstOrDefault(x => x != null);
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

    }
}
