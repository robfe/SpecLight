using System;
using System.Linq;

namespace SpecLight
{
    static class ConsoleOutcomePrinter
    {
        public static readonly int MaxStepOutcomeNameLength = Enum.GetNames(typeof (Status)).Max(x => x.Length);

        public static void PrintOutcomes(Spec spec)
        {
            if (spec.SpecTags.Any())
            {
                Console.WriteLine(String.Join(", ", spec.SpecTags.Select(x => "@" + x)));
            }
            Console.WriteLine(spec.Description);
            Console.WriteLine();
            var maxMessageWidth = spec.Outcomes.Max(x => x.Step.Description.Length + x.Step.FormattedType.Length) + 3;
            foreach (var o in spec.Outcomes)
            {
                var step = o.Step;
                var message = String.Format("{0} {1}:", step.FormattedType, step.Description);
                Console.WriteLine("{0}\t{1}\t{2}", message.PadRight(maxMessageWidth), o.Status.ToString().PadRight(MaxStepOutcomeNameLength + 1), String.Join(", ", step.Tags.Select(x => "@" + x)));
            }
        }
    }
}