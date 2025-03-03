using CachingwithRedis.Data;
using CachingwithRedis.Interfaces;
using CachingwithRedis.Model;
using CachingwithRedis.Models;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Swashbuckle.AspNetCore.Swagger;
public class Program
{
public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        string configValue = "Email";
        App app01 = CompositionRoot.BuildApp(configValue);
        app01.Run();

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddDbContext<AppDbContext>(options=> options.UseSqlite("Data Source=app.db"));


    // Add Redis distributed caching
    builder.Services.AddStackExchangeRedisCache(options =>
    {
        options.Configuration = builder.Configuration.GetConnectionString("Redis");
        options.InstanceName = "RedisCachingExample_";
    });

    builder.Services.AddRateLimiter(options =>{
        options.AddFixedWindowLimiter("fixed",config=>{
            config.Window = TimeSpan.FromSeconds(10);
            config.PermitLimit = 5; //allow max 5 requests per window.
        });

        options.AddFixedWindowLimiter("custom-limit",config =>{
            config.Window = TimeSpan.FromSeconds(15);
            config.PermitLimit = 3;
        });

        options.AddSlidingWindowLimiter("sliding",config =>{
            config.Window = TimeSpan.FromSeconds(30);
            config.PermitLimit = 10;
            config.SegmentsPerWindow = 3;
        });

        options.AddFixedWindowLimiter("login-limit", config=>{
            config.Window = TimeSpan.FromMinutes(1);
            config.PermitLimit = 3;
        });
    });

    // Add in-memory caching (optional)
    builder.Services.AddMemoryCache();

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    using(var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        db.Database.EnsureCreated();

        if(!db.Products.Any())
        {
            db.Products.AddRange(
                new Product {Name = "Laptop", Price=999.99m, Description = "High Performance"},
                new Product {Name = "Phone", Price=599.99m, Description = "Last smartphone"},
                new Product {Name = "Tablet", Price=399.99m, Description = "portable tablet"}
            );
            db.SaveChanges();
        }

        if(!db.Orders.Any())
        {
            db.Orders.AddRange(
            new Order { CustomerName = "John Doe", OrderDate = DateTime.Now.AddDays(-2), TotalAmount = 199.99m, Status = "Completed" },
            new Order { CustomerName = "Jane Smith", OrderDate = DateTime.Now.AddDays(-1), TotalAmount = 299.99m, Status = "Processing" },
            new Order { CustomerName = "Bob Johnson", OrderDate = DateTime.Now, TotalAmount = 149.99m, Status = "Pending" }
            );

            db.SaveChanges();
        }
    }

    app.Run();
    }
}