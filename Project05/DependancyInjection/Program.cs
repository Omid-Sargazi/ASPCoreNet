using DependancyInjection.Implements;
using DependancyInjection.MainClasses;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var Logger = new ConsoleLogger();
        var Service = new Service(Logger);
        Service.PerformTask();
    }
}