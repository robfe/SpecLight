using System.Collections.Generic;

namespace SpecLight.Output.ViewModel
{
    internal class TestClassViewModel
    {
        public TestClassViewModel(string name, string nameSpace)
        {
            Name = name;
            NameSpace = nameSpace;
            Specs = new List<SpecViewModel>();
        }

        public List<SpecViewModel> Specs { get; set; }
        public string Name { get; set; }
        public string NameSpace { get; set; }
    }
}
