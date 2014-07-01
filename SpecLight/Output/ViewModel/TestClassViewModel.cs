using System.Collections.Generic;

namespace SpecLight.Output.ViewModel
{
    public class TestClassViewModel
    {
        public TestClassViewModel(string name)
        {
            Name = name;
            Specs = new List<SpecViewModel>();
        }

        public List<SpecViewModel> Specs { get; set; }
        public string Name { get; set; }
    }
}