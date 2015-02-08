using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace SpecLight.Output.ViewModel
{
    internal class TestClassViewModel
    {
        public TestClassViewModel(Type type)
        {
            Specs = new List<SpecViewModel>();
         
            Name = type.Name;
            NameSpace = type.Namespace;

            var d = type.GetCustomAttribute<DescriptionAttribute>();
            if (d != null)
            {
                Description = d.Description;
            }
        }

        public List<SpecViewModel> Specs { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string NameSpace { get; set; }
    }
}
