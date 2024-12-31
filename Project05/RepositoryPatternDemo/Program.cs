using Microsoft.Extensions.DependencyInjection;
using RepositoryPatternDemo.Data;
using RepositoryPatternDemo.Implementation;
using RepositoryPatternDemo.Interfaces;

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

await productService.AddProductAsync("Laptop",1200);
await productService.AddProductAsync("Phone",800);

var products =  await productService.GetProductsAsync();
foreach (var product in products)
{
    Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
}