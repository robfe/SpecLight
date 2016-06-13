using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace SpecLight.Infrastructure
{
    static class StringHelpers
    {
        static readonly Dictionary<string, string> Replacements = @"
i=I
i've=I've
should False=shouldn't
should True=should
does False=doesn't
does True=does
will False=won't
will True=will
can False=can't
can True=can
shall False=shan't
shall True=shall
is False=isn't
is True=is
are False=aren't
are True=are
".Trim().Split('\n').Select(x => x.Trim().Split('=')).ToDictionary(x => x[0], x => x[1]);

        internal static string CreateText(MethodInfo method, object[] args)
        {
            var parameterQueue = new Queue<string>(args.Select((o, i) =>
            {
                var param = method.GetParameters().ElementAtOrDefault(i);
                return FormatValue(param, o);
            }));
            var uncameled = UnCamel(method.Name);
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

        static string FormatValue(ParameterInfo param, object v)
        {
            //special case for `bool awesomeOrSucks`
            if (param != null && param.ParameterType == typeof (bool) && v is bool && param.Name.Contains("Or"))
            {
                var options = param.Name.Split(new[] {"Or"}, StringSplitOptions.None);
                if (options.Length == 2)
                {
                    return UnCamel(options[((bool) v) ? 0 : 1]).Trim();
                }
            }

            //special case for named dates
            if (param != null && (param.ParameterType == typeof (DateTime) || param.ParameterType == typeof (DateTime?)) && v is DateTime)
            {
                switch (param.Name)
                {
                    case "date":
                        return ((DateTime) v).ToShortDateString();
                    case "time":
                        return ((DateTime) v).ToShortTimeString();
                    case "day":
                        return ((DateTime) v).ToString("dddd");
                    case "dayOfMonth":
                        return ((DateTime) v).ToString("ddd");
                    case "month":
                        return ((DateTime) v).ToString("MMMM");
                    case "year":
                        return ((DateTime) v).ToString("yyyy");
                    case "hour":
                        return ((DateTime) v).ToString("hh tt");
                    case "minute":
                        return ((DateTime) v).ToString("mm");
                }
            }

            if (v != null && v.GetType().IsArray)
            {
                var items = ((IEnumerable)v).OfType<object>().Select(x => FormatValue(param, x));
                return "[" + string.Join(", ", items) + "]";
            }

            return (v ?? "<null>").ToString();
        }

        static string UnCamel(string s)
        {
            return Regex.Replace(s, "[A-Z]", x => " " + x.Value.ToLowerInvariant());
        }

        internal static string FormatExtraData(this IDictionary<string, object> extraData)
        {
            var values = extraData.Where(x => x.Value is string).Select(x => x.Key + " = " + x.Value);
            if (!values.Any())
            {
                return "";
            }
            return "{" + string.Join(", ", values) + "}";
        }
    }

}
