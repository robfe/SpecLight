using System;
using System.Linq;

namespace SpecLight
{
    static class ConsoleOutcomePrinter
    {
        const string Empty = " (Empty)";
        public static readonly int MaxStepOutcomeNameLength = Enum.GetNames(typeof(Status)).Max(x => x.Length) + Empty.Length;

        public static void PrintOutcomes(Spec spec)
        {
            Console.WriteLine("> SpecLight results:");
            Console.WriteLine();
            if (spec.SpecTags.Any())
            {
                Console.WriteLine(String.Join(", ", spec.SpecTags.Select(x => "@" + x)));
            }
            Console.WriteLine(spec.Description);
	        Console.WriteLine();
	        
			var specData = spec.DataDictionary.FormatExtraData();
	        if (!string.IsNullOrWhiteSpace(specData))
	        {
		        Console.WriteLine(specData);
				Console.WriteLine();
	        }

            var maxMessageWidth = spec.Outcomes.Max(x => x.Step.Description.Length + x.Step.FormattedType.Length) + 3;
            foreach (var o in spec.Outcomes)
            {
                var step = o.Step;
                var message = String.Format("{0} {1}:", step.FormattedType, step.Description);
                var s = o.Status.ToString();
                if (o.Empty)
                {
                    s += Empty;
                }
                var cells = new[]
                {
                    message.PadRight(maxMessageWidth), 
                    s.PadRight(MaxStepOutcomeNameLength + 1), 
                    string.Join(", ", step.Tags.Select(x => "@" + x)),
                    step.DataDictionary.FormatExtraData()
                };
                Console.WriteLine(string.Join("\t", cells.Where(x => x != null)));
            }
        }
    }
}