using System;
using System.Collections.Concurrent;
using System.Configuration;
using System.IO;
using SpecLight.Output;
using SpecLight.Output.ViewModel;

namespace SpecLight
{
    internal static class SpecReporter
    {
        static readonly ConcurrentBag<Spec> ExecutedSpecs = new ConcurrentBag<Spec>();

        static SpecReporter()
        {
            FileName = ConfigurationManager.AppSettings["SpeclightReportFile"] ?? "Speclight.html";
            AppDomain.CurrentDomain.DomainUnload += (sender, args) => WriteSpecs();
        }

        public static string FileName { get; set; }

        public static void Add(Spec item)
        {
            ExecutedSpecs.Add(item);
        }

        static void WriteSpecs()
        {
            var viewModel = new RootViewModel(ExecutedSpecs);
            var s = new SinglePageRazorTemplate
            {
                TemplateModel = viewModel
            }.TransformText();

            File.WriteAllText(FileName, s);
        }
    }
}
