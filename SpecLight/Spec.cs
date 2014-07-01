using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public Spec(string description)
        {
            //delete any leading whitespace from each line in description
            Description = Regex.Replace(description.Trim(), @"^\s+", "", RegexOptions.Multiline);
            Steps = new List<Step>();
            SpecTags = new List<string>();
        }

        public string Description { get; set; }
        public MethodBase CallingMethod { get; set; }
        public string TestMethodNameOverride { get; set; }
        public List<Step> Steps { get; private set; }
        public List<StepOutcome> Outcomes { get; private set; }
        public List<string> SpecTags { get; private set; }


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

        static List<StepOutcome> RunOutcomes(IEnumerable<Step> steps)
        {
            var skip = false;
            var outcomes = new List<StepOutcome>();
            foreach (var step in steps)
            {
                var o = step.Execute(skip);
                outcomes.Add(o);
                switch (o.Status)
                {
                    case Status.Failed:
                    case Status.Pending:
                        skip = true;
                        break;
                }
            }
            return outcomes;
        }

        void AddStep(ScenarioBlock block, string text, Action action = null)
        {
            Steps.Add(new Step {Type = block, Description = text, Action = action ?? (() => { throw new NotImplementedException(); })});
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
    }
}