using LoggigMonitoringMatter.Day5Practice;
using LoggigMonitoringMatter.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Serilog;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var productCatalog = new Catalog<Product>();

        productCatalog.AddItem(new Product{Name = "soda",Price = 125.3m,Discount = 12.2m});
        productCatalog.AddItem(new Product{Name = "soda",Price = 125.3m,Discount = null});
        productCatalog.AddItem(new Product{Name = "soda",Price = 125.3m,Discount = 12.2m});

        var discountedItems = productCatalog.FilterBy(p => p.Discount.HasValue);
        Console.WriteLine("Discounted Products");
        foreach(var p in discountedItems)
        {
            Console.WriteLine($"{p.Name} - Price: {p.Price}, Discount: {p.Discount:P0}");
        }

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options=>{
            options.Authority = "http://localhost:8080/realms/MyApp";
            options.Audience = "myapp-client";
            options.RequireHttpsMetadata = false;
        });

        Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Information()
        .WriteTo.Console()
        .WriteTo.File("logs/app.log",rollingInterval: RollingInterval.Day).CreateLogger();

        builder.Host.UseSerilog();

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();


        var app = builder.Build();


        app.Lifetime.ApplicationStopped.Register(Log.CloseAndFlush);
        app.Run();
    }
}