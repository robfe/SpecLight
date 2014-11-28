using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace SpecLight
{
    public class Step
    {
        static readonly List<string> SkipExceptions = new List<string>("NUnit.Framework.InconclusiveException".Split(','));

        static readonly ConcurrentDictionary<MethodInfo, bool> MethodIsEmptyCache = new ConcurrentDictionary<MethodInfo, bool>();

        public Step()
        {
            Tags = new List<string>();
        }

        public ScenarioBlock Type { get; internal set; }
        public string Description { get; internal set; }
        public List<string> Tags { get; private set; }
        public object[] Arguments { get; internal set; }

        internal Action Action { get; set; }
        internal Delegate OriginalDelegate { get; set; }
        
        public int Index { get; internal set; }

        internal string FormattedType
        {
            get { return Type.ToString().PadLeft(5, ' '); }
        }



        internal StepOutcome Execute(bool shouldSkip)
        {
            var outcome = new StepOutcome {Step = this};
            if (shouldSkip)
            {
                outcome.Status = Status.Skipped;
                return outcome;
            }

            try
            {
                Action();
                outcome.Status = Status.Passed;
                outcome.Empty = MethodIsEmpty(OriginalDelegate.GetMethodInfo());
            }
            catch (NotImplementedException e)
            {
                outcome.Status = Status.Pending;
                outcome.Error = e;
            }
            catch (Exception e)
            {
                outcome.Status = SkipExceptions.Contains(e.GetType().FullName) ? Status.Skipped : Status.Failed;
                outcome.Error = e;
            }
           

            return outcome;
        }

        bool MethodIsEmpty(MethodInfo methodInfo)
        {
            return MethodIsEmptyCache.GetOrAdd(methodInfo, info =>
            {
                var il = info.GetMethodBody().GetILAsByteArray();

                //it's probably just [Nop, Ret] but i can
                return il.Length < 10 && il.All(x => x == OpCodes.Nop.Value || x == OpCodes.Ret.Value);
            });
        }
    }
}