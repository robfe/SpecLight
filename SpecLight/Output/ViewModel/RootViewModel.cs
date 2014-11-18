using System.Collections.Generic;
using System.Linq;

namespace SpecLight.Output.ViewModel
{
    internal class RootViewModel
    {
        public RootViewModel(IEnumerable<Spec> specs)
        {
            RootFolder = new FolderViewModel("");
            foreach (var spec in specs)
            {
                var c = spec.CallingMethod.DeclaringType;
                var testClassViewModel = RootFolder.SubFolder(c.Namespace).Class(c.Name);
                testClassViewModel.Specs.Add(new SpecViewModel(spec));
            }

            RootFolder.MergeSingleFolders();
        }

        public FolderViewModel RootFolder { get; set; }

        public IEnumerable<TagViewModel> Tags
        {
            get
            {
                return from feature in RootFolder.DescendantClasses()
                    from spec in feature.Specs
                    from tag in spec.EffectiveTags()
                    group spec by tag
                    into g
                    orderby g.Key
                    select new TagViewModel(g.Key, g.Select(x => x.Status));
            }
        }
    }
}