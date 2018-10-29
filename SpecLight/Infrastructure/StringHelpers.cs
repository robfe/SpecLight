using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

        static readonly HashSet<Type> NumericTypes = new HashSet<Type>
        {
            typeof(decimal),
            typeof(double),
            typeof(float),
            typeof(int),
            typeof(long)
        };

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
            if (param != null && param.ParameterType == typeof (bool) && v is bool b && param.Name.Contains("Or"))
            {
                var options = param.Name.Split(new[] {"Or"}, StringSplitOptions.None);
                if (options.Length == 2)
                {
                    return UnCamel(options[b ? 0 : 1]).Trim();
                }
            }

            //special case for `string **Quoted`
            if (param != null && v is string s && param.Name.EndsWith("Quoted"))
            {
                return '"' + s + '"';
            }

            //special case for named dates
            if (param != null && (param.ParameterType == typeof (DateTime) || param.ParameterType == typeof (DateTime?)) && v is DateTime dateTime)
            {
                switch (param.Name)
                {
                    case "date":
                        return dateTime.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
                    case "time":
                        return dateTime.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern);
                    case "day":
                        return dateTime.ToString("dddd");
                    case "dayOfMonth":
                        return dateTime.ToString("ddd");
                    case "month":
                        return dateTime.ToString("MMMM");
                    case "year":
                        return dateTime.ToString("yyyy");
                    case "hour":
                        return dateTime.ToString("hh tt");
                    case "minute":
                        return dateTime.ToString("mm");
                }
            }

            //special case for `numeric amount`
            if (v != null && param != null && IsNumeric(param.ParameterType))
            {
                if (param.Name.ToLower().Contains("amount") || param.Name.ToLower().EndsWith("dollars"))
                {
                    return $"{v:C}";
                }
                if (param.Name.ToLower().EndsWith("percent"))
                {
                    return $"{v:P}";
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

        static bool IsNumeric(Type type)
        {
            return NumericTypes.Contains(Nullable.GetUnderlyingType(type) ?? type);
        }
    }

}
