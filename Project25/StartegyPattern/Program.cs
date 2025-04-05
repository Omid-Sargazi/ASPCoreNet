using StartegyPattern.BuilderPattern;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var pizza = new PizzaBuilder()
        .SetSize("Large")
        .AddCheese("Mozarella")
        .AddTopping("Peperoni")
        .Build();
        Console.WriteLine($"Pizza Size: {pizza.Size}");
    }
}