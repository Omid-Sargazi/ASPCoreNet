using BuilderPattern.Builders;
using BuilderPattern.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Builder");
        var product = new ProductBuilder()
        .SetName("Laptop")
        .SetDescription("Made in Japan")
        .SetId(1)
        .SetIsAvailable(true)
        .Build();
    }
}