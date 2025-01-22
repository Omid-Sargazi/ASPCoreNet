using Domain.ValueObjects;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");
        
        var address = new Address("123 Main St", "New York", "10001");
    }
}