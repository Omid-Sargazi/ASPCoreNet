using Microsoft.Extensions.DependencyInjection;
using RepositoryPatternExample.Data;
using RepositoryPatternExample.Implements;
using RepositoryPatternExample.Interfaces;

var services = new ServiceCollection();

services.AddDbContext<AppDbContext>();

services.AddScoped<IProductRepository,ProductRepository>();

services.AddScoped<IProductService,ProductService>();

var serviceProvider = services.BuildServiceProvider();

using(var scope = serviceProvider.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();
}


var productService = serviceProvider.GetRequiredService<IProductService>();

await productService.AddProductAsync("Product 1", 100);
await productService.AddProductAsync("Product 2", 200);

var products = await productService.GetProductsAsync();
foreach (var product in products)
{
    Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
}