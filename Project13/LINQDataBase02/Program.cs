using LINQDataBase02.Data;
using LINQDataBase02.Models;
using Microsoft.AspNetCore.SignalR.Protocol;
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

            //Using First and FirstOrDefault
            var FirstExpensiveProduct = context.Products
            .FirstOrDefault(p => p.Price >500);
            Console.WriteLine($"First Expensive product:{FirstExpensiveProduct?.Name} ");

            //Check if there are any products in the "Electronics" category.
             bool anyElectronics = context.Products.Any(p=>p.Category.Name =="Electronics");
             Console.WriteLine($"Are there any electronics:{anyElectronics}");

             //Count the number of products in the "Clothing" category.
             int clothingCount = context.Products
             .Count(p => p.Category.Name == "Clothing");
             Console.WriteLine($"number of clothnig Products:{clothingCount}");

             //Calculate the total price of all products.
             decimal totalPrice = context.Products
             .Sum(p => p.Price);
             Console.WriteLine($"Total price of all Products:{totalPrice}");

             //Group products by category.
             var productsByCategory = context.Products.GroupBy(p => p.Category.Name)
             .Select(g=>new{Category = g.Key,Product = g.ToList()}).ToList();
             Console.WriteLine("Products grouped by Ctegory:");
             foreach(var group in productsByCategory)
             {
                Console.WriteLine($"Category:{group.Category}");
                foreach(var product in group.Product)
                {
                    Console.WriteLine($"{product.Name}, {product.Price}");
                }
             }

             //Join products and categories manually.
            //  var productCategoryJoin = context.Products
            //  .Join(context.Categories,
            //     p=>p.CategoryId,
            //     c=>c.Id,
            //     (p,c)=>new {p.Name, Category=c.Name}
            // ).ToList();

            var productCategoryJoin = context.Products
            .Join(context.Categories,
                p=>p.CategoryId,
                c => c.Id,
                (p,c)=>new{
                    p.Name,
                    Category=c.Name
                }
            ).ToList();
            Console.WriteLine("Products with categories:");
            foreach(var item in productCategoryJoin)
            {
                Console.WriteLine($"{item.Name}, {item.Category}");
            }

            //Basic Join() with a New Anonymous Type
            var result = context.Products
            .Join(context.Categories,
                p => p.CategoryId,
                c => c.Id,
                (p,c) => new {p.Name,Category= c.Name}
            ).ToList();
            foreach(var item in result)
            {
                Console.WriteLine($"Product:{item.Name}, Category:{item.Category}");
            }

            //Join() with a Where() Condition
            var reultsJoinAndWhere = context.Products
                .Join(context.Categories,
                    p => p.CategoryId,
                    c => c.Id,
                    (p, c) => new { p.Name, categoryName = c.Name, p.Price })
                        .Where(x => x.Price > 500)
                        .ToList();

            foreach(var item in reultsJoinAndWhere)
            {
                Console.WriteLine($"{item.Name},{item.categoryName},{item.Price}");
            }

            //Join() with Multiple Conditions
            var JoinMultipleConditions = context.Products
            .Join(context.Categories,
                p => p.CategoryId,
                c => c.Id,
                (p,c)=> new{p.Name, CategoryName=c.Name, p.Price}
            ).Where(x=> x.Name.StartsWith("j")).ToList();
            Console.WriteLine("Join() with Multiple Conditions.");
            foreach(var item in JoinMultipleConditions)
            {
                Console.WriteLine($"{item.Name} {item.CategoryName} {item.Price}");
            }

            //Join() and Order by Product Name
            var JoinOrderProductName = context.Products
            .Join(context.Categories,
                p=>p.CategoryId,
                c=>c.Id,
                (p,c)=>new{p.Name, CategoryName=c.Name}
            ).OrderBy(x=>x.Name).ToList();
            Console.WriteLine("Join() and Order by Product Name");
            foreach(var item in JoinOrderProductName)
            {
                Console.WriteLine($"{item.Name} {item.CategoryName}");
            }

            //Join() with Select Specific Fields
            var JoinSelectSpecificFields = context.Products
            .Join(context.Categories,
                p=>p.CategoryId,
                c=>c.Id,
                (p,c)=>new {ProductName = p.Name, CategoryName = c.Name}
            ).ToList();

            //Join() with Aggregation (Counting Products per Category)
            var JoinAggregationProductsCategory = context.Categories
                .Join(context.Products,
                    c=>c.Id,
                    p=>p.CategoryId,
                    (c,p)=>new {c.Name, p.Id}
                ).GroupBy(x=>x.Name)
                .Select(g=>new {Category = g.Key, ProductCount=g.Count()}).ToList();
            
            foreach(var item in JoinAggregationProductsCategory)
            {
                Console.WriteLine($"Category: {item.Category},Count:{item.ProductCount}");
            }

            //Join() with FirstOrDefault()
            var firstProductInCategory = context.Products
            .Join(context.Categories,
                p=>p.CategoryId,
                c=>c.Id,
                (p,c)=>new {p.Name, Category=c.Name}
            ).FirstOrDefault();

            if(firstProductInCategory !=null)
            {
                Console.WriteLine($"First Product in Category:{firstProductInCategory.Name}");
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