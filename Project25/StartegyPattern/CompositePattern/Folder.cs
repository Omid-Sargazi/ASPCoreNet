namespace  StartegyPattern.CompositePattern
{
    public class Folder : IFileSystemItem
    {
        private List<IFileSystemItem> files = new List<IFileSystemItem>();
        public void Add(IFileSystemItem file) => files.Add(file);
        public void Show() => files.Foreach(f => f.Show());
    }
}