namespace  StartegyPattern.CompositePattern
{
    public class FileSystem : IFileSystemComponent
    {
        public string Name { get; private set; }
        private long Size;
        
        public File(string name, long size)
        {
            Name = name;
            Size = size;
        }

        public long GetSize() => Size;
        
        public void ShowDetails(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}File: {Name}, Size: {Size} bytes");
        }
        
        public IFileSystemComponent Find(string name)
        {
            return Name == name ? this : null;
        }
        
        public bool Delete()
        {
            Console.WriteLine($"Deleting file: {Name}");
            return true;
        }
        
        public IFileSystemComponent Copy(string newName)
        {
            return new File(newName, Size);
        }
    }
}