namespace StartegyPattern.CompositePattern
{
     public class Directory : IFileSystemComponent
    {
        public string Name { get; private set; }
        private List<IFileSystemComponent> _children = new List<IFileSystemComponent>();
        
        public Directory(string name)
        {
            Name = name;
        }
        
        public void Add(IFileSystemComponent component)
        {
            _children.Add(component);
        }
        
        public void Remove(IFileSystemComponent component)
        {
            _children.Remove(component);
        }
        
        public long GetSize()
        {
            return _children.Sum(child => child.GetSize());
        }
        
        public void ShowDetails(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}Directory: {Name}, Size: {GetSize()} bytes");
            foreach (var child in _children)
            {
                child.ShowDetails(indent + 4);
            }
        }
        
        public IFileSystemComponent Find(string name)
        {
            if (Name == name)
                return this;
                
            foreach (var child in _children)
            {
                var found = child.Find(name);
                if (found != null)
                    return found;
            }
            
            return null;
        }
    }
    public bool Delete()
        {
            if (_children.Count > 0)
            {
                Console.WriteLine($"Deleting directory and all contents: {Name}");
                foreach (var child in _children.ToList())
                {
                    child.Delete();
                }
                _children.Clear();
            }
            return true;
        }
        
        public IFileSystemComponent Copy(string newName)
        {
            Directory newDir = new Directory(newName);
            foreach (var child in _children)
            {
                newDir.Add(child.Copy(child.Name));
            }
            return newDir;
        }
}
