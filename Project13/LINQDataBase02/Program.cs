// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }

// app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast");

// app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }



using LINQDataBase02.Data;
using LINQDataBase02.Models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<AppDbContext>(options => {
            options.UseSqlServer(connectionString);
        });

        builder.Services.AddOpenApi();
        var app = builder.Build();

        using(var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();
            SeedDatabase(context);
        }

        using(var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            Console.WriteLine("Hello");
            var products = context.Products.ToList();
            Console.WriteLine("All Products");
            foreach(var product in products)
            {
                Console.WriteLine($"{product.Name}, {product.Price}");
            }
        }





    }

    private static void SeedDatabase(AppDbContext context)
    {
        if(!context.Categories.Any())
        {
           var categories = new List<Category>
           {
             new Category {Name="Electronics"},
            new Category {Name="Clothing"},
           };

        context.Categories.AddRange(categories);
        context.SaveChanges();

        var products = new List<Product>
        {
           new Product { Name = "Laptop", Price = 1000, CategoryId = 1 },
            new Product { Name = "Smartphone", Price = 800, CategoryId = 1 },
            new Product { Name = "T-Shirt", Price = 20, CategoryId = 2 },
            new Product { Name = "Jeans", Price = 50, CategoryId = 2 }

        };

        context.Products.AddRange(products);
        context.SaveChanges();

        }

    }
}