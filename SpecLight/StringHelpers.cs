using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SpecLight
{
    static class StringHelpers
    {
        internal static string CreateText(string name, params object[] args)
        {
            var parameterQueue = new Queue<string>(args.Select(x => x.ToString()));
	        var uncameled = Regex.Replace(name, "[A-Z]", x => " " + x.Value.ToLowerInvariant());
	        var paramsSubsituted = Regex.Replace(uncameled, "_", x => parameterQueue.Any() ? " " + parameterQueue.Dequeue() + " " : " <missing parameter> ");

			
            if (parameterQueue.Any())
            {
                paramsSubsituted += "(" + string.Join(", ", parameterQueue) + ")";
            }


			var fixI = (paramsSubsituted + " ").Replace(" i ", " I ").Replace(" ive ", " I've ");
            var normalizeSpaces = Regex.Replace(fixI, "\\s+", " ");
            return normalizeSpaces.Trim();
        }
    }
}