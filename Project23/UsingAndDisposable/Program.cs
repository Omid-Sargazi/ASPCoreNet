public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        using(StreamWriter writer = new StreamWriter("example.txt"))
        {
            writer.WriteLine("Hello World");
        }
        Console.WriteLine("The file has been written");
    }
}