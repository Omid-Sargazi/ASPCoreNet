using System.Reflection;
using AbstarctFactoryPattern;
using AbstarctFactoryPattern.Factory;
using AbstarctFactoryPattern.interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        Console.WriteLine("Eneter config for factory");
        string config = Console.ReadLine();

        IUIFactory factory;

        if(config == "win")
        {
            factory = new WinFactory();
        }
        else if(config == "mac")
        {
            factory = new MacOSFactory();
        }
        else{
            throw new ArgumentException("Enetr a correct config");
        }

        ClientUI client = new ClientUI(factory);
        client.RenderUI();
    }
}