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

            // Filtering with Where
            var expensiveProducts = context.Products
            .Where(p => p.Price > 500).ToList();
            Console.WriteLine("Expensive products:");
            foreach(var product in expensiveProducts)
            {
                Console.WriteLine($"{product.Name},{product.Price}");
            }

            //Sorting with OrderBy
            var sortedProducts = context.Products
            .OrderBy(p=>p.Price).ToList();
            Console.WriteLine("Sorted by Price");
            foreach(var product in sortedProducts)
            {
                Console.WriteLine($"{product.Name},{product.Price}");
            }

            //Sort products by price in descending order
            var sortedDesending = context.Products
            .OrderByDescending(p => p.Price).ToList();
            Console.WriteLine("Products sorted by Price (Desending)");
            foreach(var product in sortedDesending)
            {
                Console.WriteLine($"{product.Name},{product.Price}");
            }

            //Get only product names and prices.
            var productDetails = context.Products
            .Select(p=> new {p.Price, p.Name}).ToList();
            Console.WriteLine("Product Details:");
            foreach(var product in productDetails)
            {
                Console.WriteLine($"{product.Name},{product.Price}");
            }

            //Get products with their categories. 
            var productsWithCategories = context.Products
            .Include(p => p.Category).ToList();
            Console.WriteLine("Products with categories:");
            foreach(var product in productsWithCategories)
            {
                Console.WriteLine($"{product.Name}, {product.Category.Name}");
            }

            //Get the first product with a price greater than 500.
            var firstExpensiveProduct = context.Products.
            FirstOrDefault(p => p.Price >500);

            Console.WriteLine(firstExpensiveProduct !=null ? 
            firstExpensiveProduct.ToString() :"No product found with price greater than 500");

        
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