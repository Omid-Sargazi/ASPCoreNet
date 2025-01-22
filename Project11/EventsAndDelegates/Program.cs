public class Program
{
    public delegate void Notify(string message);
    public static void Main(string[] args)
    {
        Notify notification = ShowMessage;
        Console.WriteLine("Hello World!");
        notification("Hello, this is a simple delegate example!");
    }

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}