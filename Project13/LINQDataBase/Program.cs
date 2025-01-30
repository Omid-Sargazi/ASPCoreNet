using LINQDataBase.Data;
using LINQDataBase.Models;
using Microsoft.EntityFrameworkCore;
public class Program
{
    public static void Main(string[] args)
    {

    var builder = WebApplication.CreateBuilder(args);
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(connectionString));

    // Add services to the container.
    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
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
            var products = context.Products.ToList();
            Console.WriteLine("All Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}: {product.Name} - ${product.Price}");
            }

            var expensiveProducts = products.Where(p => p.Price>500).ToList();
            Console.WriteLine("Expensive Products:");
            foreach(var product in expensiveProducts)
            {
                Console.WriteLine($"{product.Name},{product.Price}");
            }

            var sortedProducts = products.OrderBy(p => p.Price).ToList();
            Console.WriteLine("Sorted products on Price");
            foreach(var product in sortedProducts)
            {
                Console.WriteLine(product.Price);
            }

            var sortedProductsOnName = products.OrderBy(p => p.Name).ToList();
            Console.WriteLine("Sorted on Name");
            foreach(var product in sortedProductsOnName)
            {
                Console.WriteLine(product.Name);
            }

    }


       // Configure the HTTP request pipeline.
    // if (app.Environment.IsDevelopment())
    // {
    //     app.MapOpenApi();
    // }

    // app.UseHttpsRedirection();


    // app.Run();

    }  


    private static void SeedDatabase(AppDbContext context)
    {
        if (!context.Categories.Any())
        {
            var categories = new List<Category>
            {
                new Category { Name = "Electronics" },
                new Category { Name = "Clothing" }
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


