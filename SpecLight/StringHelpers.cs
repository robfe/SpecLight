using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace SpecLight
{
    static class StringHelpers
    {
        static readonly Dictionary<string, string> Replacements = @"
i=I
i've=I've
should False=shouldn't
should True=should
will False=won't
will True=will
can False=can't
can True=can
shall False=shan't
shall True=shall
is False=isn't
is True=is
".Trim().Split('\n').Select(x => x.Trim().Split('=')).ToDictionary(x => x[0], x => x[1]);

        internal static string CreateText(MethodInfo method, params object[] args)
        {
            var parameterQueue = new Queue<string>(args.Select((o, i) =>
            {
	            var param = method.GetParameters().ElementAtOrDefault(i);
	            if (param != null && param.ParameterType == typeof (bool) && o is bool && param.Name.Contains("Or"))
	            {
		            var options = param.Name.Split(new[] {"Or"}, StringSplitOptions.None);
		            if (options.Length == 2)
		            {
			            return Regex.Replace(options[((bool) o) ? 0 : 1], "[A-Z]", x => " " + x.Value.ToLowerInvariant()).Trim();
		            }
	            }
	            return o.ToString();
            }));
            var uncameled = Regex.Replace(method.Name, "[A-Z]", x => " " + x.Value.ToLowerInvariant());
            var paramsSubsituted = Regex.Replace(uncameled, "_", x => parameterQueue.Any() ? " " + parameterQueue.Dequeue() + " " : " <missing parameter> ");

            
            if (parameterQueue.Any())
            {
                paramsSubsituted += "(" + string.Join(", ", parameterQueue) + ")";
            }

            var sb = new StringBuilder(paramsSubsituted);
            foreach (var kvp in Replacements)
            {
                sb.Replace(" " + kvp.Key + " ", " " + kvp.Value + " ");
            }
            var normalizeSpaces = Regex.Replace(sb.ToString(), "\\s+", " ");
            return normalizeSpaces.Trim();
        }


    }

}