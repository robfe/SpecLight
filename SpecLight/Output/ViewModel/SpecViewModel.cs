using System.Collections.Generic;
using System.Linq;

namespace SpecLight.Output.ViewModel
{
    internal class SpecViewModel
    {
        public SpecViewModel(Spec spec)
        {
            Spec = spec;
            Status = spec.Outcomes.Select(x => x.Status).DefaultIfEmpty(Status.Passed).Max();
            MethodName = Spec.TestMethodNameOverride;
        }

        public Status Status { get; set; }
        public Spec Spec { get; set; }
        public string MethodName { get; set; }

        public IEnumerable<string> EffectiveTags()
        {
            return Spec.Steps.SelectMany(x => x.Tags).Concat(Spec.SpecTags);
        }
    }
}
