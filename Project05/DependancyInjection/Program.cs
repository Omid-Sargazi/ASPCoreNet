using DependancyInjection.Implements;
using DependancyInjection.Interfaces;
using DependancyInjection.MainClasses;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        // var Logger = new ConsoleLogger();
        // var Service = new Service(Logger);
        // Service.PerformTask();
        
        // //Next
        // var service02 = new Service02()
        // {
        //     logger = new ConsoleLogger()
        // };
        // service02.PerformTask();
        // //Next:Injecting a dependency through a method parameter.

        // var service03 = new Service03();
        // service03.PerformTask(new ConsoleLogger());
        // //Using a DI Container 

        var services = new ServiceCollection();
        services.AddTransient<ILogger, ConsoleLogger>();
        services.AddTransient<Service>();
        services.AddScoped<ILogger,ConsoleLogger>();


        var provider = services.BuildServiceProvider();
        using(var scope = provider.CreateScope())
        {
            var service = scope.ServiceProvider.GetRequiredService<Service>();
            service.PerformTask();
        }

        var service04 = provider.GetService<Service>();
       // service04.PerformTask();



       //Singleton Lifetime Example
       services.AddSingleton<ILogger,ConsoleLogger>();
       
        var logger1=  provider.GetService<ILogger>();
        var logger2=  provider.GetService<ILogger>();

        Console.WriteLine(ReferenceEquals(logger1,logger2));

        //Transient Lifetime Example
        services.AddTransient<ILogger,ConsoleLogger>();

        var logger3=  provider.GetService<ILogger>();
        var logger4= provider.GetService<ILogger>();

        Console.WriteLine(ReferenceEquals(logger3,logger4));
       
    }
}