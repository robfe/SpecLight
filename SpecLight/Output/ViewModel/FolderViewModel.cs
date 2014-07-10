using System.Collections.Generic;
using System.Linq;

namespace SpecLight.Output.ViewModel
{
    internal class FolderViewModel
    {
        public FolderViewModel(string name)
        {
            Name = name;
            Classes = new List<TestClassViewModel>();
            SubFolders = new List<FolderViewModel>();
        }

        public string Name { get; set; }
        public List<TestClassViewModel> Classes { get; set; }
        public List<FolderViewModel> SubFolders { get; set; }

        public IEnumerable<TestClassViewModel> DescendantClasses()
        {
            foreach (var descendantFeature in SubFolders.OrderBy(x => x.Name).SelectMany(featureFolderViewModel => featureFolderViewModel.DescendantClasses()))
            {
                yield return descendantFeature;
            }
            foreach (var featureViewModel in Classes.OrderBy(x => x.Name))
            {
                yield return featureViewModel;
            }
        }

        public FolderViewModel SubFolder(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return this;
            }

            var split = path.Split(new[] {'.'}, 2);
            var folder = SubFolders.SingleOrDefault(x => x.Name == split[0]);

            if (folder == null)
            {
                folder = new FolderViewModel(split[0]);
                SubFolders.Add(folder);
            }
            return folder.SubFolder(split.ElementAtOrDefault(1));
        }

        public TestClassViewModel Class(string name)
        {
            var c = Classes.SingleOrDefault(x => x.Name == name);
            if (c == null)
            {
                c = new TestClassViewModel(name);
                Classes.Add(c);
            }
            return c;
        }
    }
}