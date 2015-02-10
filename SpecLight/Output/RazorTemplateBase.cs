using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Web.WebPages;
using SpecLight.Output.ViewModel;

namespace SpecLight.Output
{
    internal class RazorTemplateBase
    {
        readonly StringBuilder _stringBuilder = new StringBuilder();
        string _content;
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
            _stringBuilder.Append(textToAppend);
        }

        public void Write(object value)
        {
            if (value == null)
            {
                return;
            }
            var helperResult = value as HelperResult;
            WriteLiteral(helperResult != null ? helperResult.ToHtmlString() : Convert.ToString(value, CultureInfo.InvariantCulture));
        }

        public string RenderBody()
        {
            return _content;
        }

        public string TransformText()
        {
            Execute();
            if (Layout != null)
            {
                Layout._content = _stringBuilder.ToString();
                return Layout.TransformText();
            }
            return _stringBuilder.ToString();
        }

        public void Clear()
        {
            _stringBuilder.Clear();

            if (Layout != null)
            {
                Layout._content = "";
            }
        }

        public void WriteTo(TextWriter writer, object value)
        {
            var helperResult = value as HelperResult;

            if (helperResult != null)
            {
                helperResult.WriteTo(writer);
            }
            else
            {
                writer.Write(Convert.ToString(value, CultureInfo.InvariantCulture));
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
