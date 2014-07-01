using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SpecLight
{
    static class StringHelpers
    {
        internal static string CreateText(string name, params object[] args)
        {
            var q = new Queue<string>(args.Select(x => x.ToString()));
            var s = Regex.Replace(name, "_", x => q.Any() ? " " + q.Dequeue() + " " : "?");
            if (q.Any())
            {
                s += "(" + string.Join(", ", q) + ")";
            }
            return UnCamel(s);
        }

        internal static string UnCamel(string s)
        {
            var addSpaces = Regex.Replace(s, "[A-Z]", x => " " + x.Value.ToLowerInvariant());
            var fixI = (addSpaces + " ").Replace(" i ", " I ").Replace(" ive ", " I've ");
            var normalizeSpaces = Regex.Replace(fixI, "\\s+", " ");
            return normalizeSpaces.Trim();
        }
    }
}