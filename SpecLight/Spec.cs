using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace SpecLight
{
    public partial class Spec
    {
        Action _finalActions;
        readonly ExpandoObject _extraData = new ExpandoObject();

        public Spec(string description)
        {
            //delete any leading whitespace from each line in description
            Description = Regex.Replace(description.Trim(), @"^\s+", "", RegexOptions.Multiline);
            Steps = new List<Step>();
            SpecTags = new List<string>();
            Fixtures = new List<ISpecFixture>();
        }

        public string Description { get; private set; }
        public MethodBase CallingMethod { get; set; }
        public string TestMethodNameOverride { get; set; }
        public List<Step> Steps { get; private set; }
        
        /// <summary>
        /// A bag to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataDictionary"/>. Any contents of type string will be printed to output.
        /// </summary>
        public dynamic DataBag { get { return _extraData; }}

        /// <summary>
        /// A dictionary to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataBag"/>. Any contents of type string will be printed to output.
        /// </summary>
        public IDictionary<string, object> DataDictionary { get { return _extraData; }}


        internal List<StepOutcome> Outcomes { get; private set; }
        internal List<string> SpecTags { get; private set; }
        internal List<ISpecFixture> Fixtures { get; private set; }


        /// <summary>
        ///     Run the spec, printing its results to the output windows, and re-throwing the first exception that it encountered
        ///     (such as an Assert failure)
        ///     Be sure to call Execute from your unit test method directly so that it can detect its calling method correctly
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Execute([CallerMemberName] string testMethodNameOverride = null)
        {
            //run me
            CallingMethod = CallingMethod ?? new StackFrame(1, false).GetMethod();
            TestMethodNameOverride = testMethodNameOverride;
            Outcomes = RunOutcomes(Steps);

            if (_finalActions != null)
            {
                //we're doing this here because if it throws, the test is actually invalid, and all the user should see is the exception from cleanup
                _finalActions();
            }
            SpecReporter.Add(this);

            //print it all
            ConsoleOutcomePrinter.PrintOutcomes(this);

            //rethrow the first error if any
            var firstException = Outcomes.Select(x => x.Error).FirstOrDefault(x => x != null);
            if (firstException != null)
            {
                ExceptionDispatchInfo.Capture(firstException).Throw();
            }
        }

        List<StepOutcome> RunOutcomes(IEnumerable<Step> steps)
        {
            Fixtures.ForEach(x => x.SpecSetup(this));
            var skip = false;
            var outcomes = new List<StepOutcome>();
            foreach (var step in steps)
            {
                Console.WriteLine("> SpecLight {2} step: {0} {1}", step.Type, step.Description, skip?"skipping":"executing");
                Fixtures.ForEach(x => x.StepSetup(step));
                var o = step.Execute(skip);
                Fixtures.ForEach(x => x.StepTeardown(step));
                outcomes.Add(o);
                switch (o.Status)
                {
                    case Status.Failed:
                    case Status.Pending:
                        skip = true;
                        break;
                }
            }
            Fixtures.ForEach(x => x.SpecTeardown(this));
            return outcomes;
        }

        void AddStep(ScenarioBlock block, string text, Action action, Delegate originalDelegate, object[] arguments)
        {
            Steps.Add(new Step
            {
                Type = block,
                Description = text, 
                Action = action, 
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

    }
}