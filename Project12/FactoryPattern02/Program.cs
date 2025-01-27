using FactoryPattern02;
using FactoryPattern02.Factories;
using FactoryPattern02.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        // Create a factory
        IModels model = new LuxuryProductFactory();

        Application app = new Application(model);
        app.Created();

    }
}