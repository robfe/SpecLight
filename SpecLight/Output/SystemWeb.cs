using System.Globalization;
using System.IO;

// ReSharper disable once CheckNamespace
namespace System.Web.WebPages
{
    internal class HelperResult
    {
        readonly Action<TextWriter> _action;

        public HelperResult(Action<TextWriter> action)
        {
            _action = action;
        }

        public void WriteTo(TextWriter writer)
        {
            _action(writer);
        }

        public string ToHtmlString()
        {
            return ToString();
        }

        public override string ToString()
        {
            using (var stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                _action(stringWriter);
                return stringWriter.ToString();
            }
        }
    }
}
