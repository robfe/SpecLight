using System.Collections.Generic;

namespace SpecLight.Output.ViewModel
{
    public class TagViewModel
    {
        public TagViewModel(string name, IEnumerable<Status> statuses)
        {
            Name = name;
            Statuses = statuses;
        }

        public string Name { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}