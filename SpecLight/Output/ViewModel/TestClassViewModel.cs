using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace SpecLight.Output.ViewModel
{
    internal class TestClassViewModel
    {
        readonly Type type;

        public TestClassViewModel(Type type)
        {
            this.type = type;

            var d = type.GetCustomAttribute<DescriptionAttribute>();
            if (d != null)
            {
                Description = d.Description;
            }

            Specs = new List<SpecViewModel>();
        }

        public List<SpecViewModel> Specs { get; set; }
        public string Description { get; set; }
        public string Name => type.Name;
        public string Namespace => type.Namespace;

        public void TrySortTestsByClassLayout()
        {
            var correctOrder = type.GetMethods().Cast<MethodBase>().ToList();
            Specs.Sort((x, y) => correctOrder.IndexOf(x.Spec.CallingMethod).CompareTo(correctOrder.IndexOf(y.Spec.CallingMethod)));
        }
    }

}
