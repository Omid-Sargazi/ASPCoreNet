public class FileStorage:IStorage
{
    public void Save(string message)
    {
        Console.WriteLine($"File storage: {message}");
    }
}