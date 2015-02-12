using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading.Tasks;
using SpecLight.Infrastructure;

namespace SpecLight
{
    public class Step
    {
        static readonly List<string> SkipExceptions = new List<string>("NUnit.Framework.InconclusiveException".Split(','));//todo: any more?
        static readonly ConcurrentDictionary<MethodInfo, bool> MethodIsEmptyCache = new ConcurrentDictionary<MethodInfo, bool>();

        readonly ExpandoObject _extraData = new ExpandoObject();

        public Step()
        {
            Tags = new List<string>();
        }

        public ScenarioBlock Type { get; internal set; }
        public string Description { get; internal set; }
        public List<string> Tags { get; private set; }
        public object[] Arguments { get; internal set; }
        public Spec Spec { get; internal set; }
        public int Index { get; internal set; }

        /// <summary>
        /// A bag to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataDictionary"/>. Any contents of type string will be printed to output.
        /// </summary>
        public dynamic DataBag { get { return _extraData; }}

        /// <summary>
        /// A dictionary to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataBag"/>. Any contents of type string will be printed to output.
        /// </summary>
        public IDictionary<string, object> DataDictionary { get { return _extraData; }}

        internal Func<Task> Action { get; set; }
        internal Delegate OriginalDelegate { get; set; }

        internal string FormattedType
        {
            get { return Type.ToString().PadLeft(5, ' '); }
        }


        internal async Task<StepOutcome> Execute(bool shouldSkip)
        {
            var outcome = new StepOutcome {Step = this};
            if (shouldSkip)
            {
                outcome.Status = Status.Skipped;
                return outcome;
            }

            try
            {
                await Action();
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

                //it's probably just [Nop, Ret]
                return il.Length < 10 && il.All(x => x == OpCodes.Nop.Value || x == OpCodes.Ret.Value);
            });
        }
    }
}
