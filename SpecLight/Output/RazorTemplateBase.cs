using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web.WebPages;
using SpecLight.Output.ViewModel;


namespace SpecLight.Output
{
    internal class RazorTemplateBase
    {
        readonly StringBuilder stringBuilder = new StringBuilder();
        string content;
        public RazorTemplateBase Layout { get; set; }
        public RootViewModel TemplateModel { get; set; }

        public virtual void Execute()
        {
        }

        public void WriteLiteral(string textToAppend)
        {
            if (String.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            stringBuilder.Append(textToAppend);
        }

        public void Write(object value)
        {
            if (value == null)
            {
                return;
            }

            WriteLiteral(value is HelperResult helperResult ? helperResult.ToHtmlString() : WebUtility.HtmlEncode(Convert.ToString(value, CultureInfo.InvariantCulture)));
        }

        public string RenderBody()
        {
            return content;
        }

        public string TransformText()
        {
            Execute();
            if (Layout != null)
            {
                Layout.content = stringBuilder.ToString();
                return Layout.TransformText();
            }
            return stringBuilder.ToString();
        }

        public void Clear()
        {
            stringBuilder.Clear();

            if (Layout != null)
            {
                Layout.content = "";
            }
        }

        public void WriteTo(TextWriter writer, object value)
        {
            if (value is HelperResult helperResult)
            {
                helperResult.WriteTo(writer);
            }
            else
            {
                writer.Write(WebUtility.HtmlEncode(Convert.ToString(value, CultureInfo.InvariantCulture)));
            }
        }

        public void WriteLiteralTo(TextWriter writer, string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            writer.Write(textToAppend);
        }

        protected HelperResult RawHtml(string s)
        {
            return new HelperResult(writer => writer.Write(s));
        }

        protected HelperResult IncludeEmbeddedResource(string s)
        {
            return new HelperResult(writer =>
            {
                var type = GetType();
                var stream = type.Assembly.GetManifestResourceStream(type.Namespace + "." + s);
                WriteLiteralTo(writer, new StreamReader(stream).ReadToEnd());
            });
        }
    }
}


namespace System.Web.WebPages
{
    public class HelperResult
    {
        private readonly Action<TextWriter> action;

        public HelperResult(Action<TextWriter> action)
        {
            this.action = action ?? throw new ArgumentNullException(nameof(action));
        }

        public string ToHtmlString()
        {
            return ToString();
        }

        public override string ToString()
        {
            using (var writer = new StringWriter(CultureInfo.InvariantCulture))
            {
                action(writer);
                return writer.ToString();
            }
        }

        public void WriteTo(TextWriter writer)
        {
            action(writer);
        }
    }

}
