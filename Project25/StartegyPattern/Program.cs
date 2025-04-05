using StartegyPattern.PrototypePattern;
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

        var baseSoldier = new Soldier("Rifle","Light Armor", 100);
        var soldier2 = new Soldier(baseSoldier.Weapon, baseSoldier.Armor, baseSoldier.Health);
        soldier2.Weapon = "Shotgun";
        Console.WriteLine(soldier2.Weapon, baseSoldier.Weapon);

    }
}