public class CloudStorage:IStorage
{
    public void Save(string message)
    {
        Console.WriteLine($"Cloud storage: {message}");
    }
}