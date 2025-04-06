namespace  StartegyPattern.CompositePattern
{
    public interface IFileSystemComponent
    {
         string Name { get; }
        long GetSize();
        void ShowDetails(int indent = 0);
        IFileSystemComponent Find(string name);
        bool Delete();
        IFileSystemComponent Copy(string newName);
    }
}