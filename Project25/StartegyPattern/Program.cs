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

        var person = new PersonBuilder()
        .WithLastName("Omid")
        .WithLastName("Sa")
        .WithAge(42)
        .WithAddress("Australis").
        Build();
        Console.WriteLine(person.Age);
    }
}