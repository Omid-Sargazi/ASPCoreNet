namespace  StartegyPattern.CompositePattern
{
    public class Folder
    {
        private List<File> files = new List<File>();
        public void Add(File file) => files.Add(file);
        public void Show() => files.Foreach(f => f.Show());
    }
}