using AbstarctFactory;
using AbstarctFactory.Factories;
using AbstarctFactory.Interfaces;

namespace AbstarctFactory
{
    public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        
        //Create Factory
        ILogger logger;

        Console.WriteLine($"Eneter Win or Mac for log in file and database");
        string choice = Console.ReadLine();

        if(choice == "Win")
            logger = new WndowsFactoryLogger();
        else if(choice=="Mac")
            logger = new MacFactoryLogger();
        else 
            throw new ArgumentException();
        
        Application app = new Application(logger);
        app.Run();


    }
}
}
