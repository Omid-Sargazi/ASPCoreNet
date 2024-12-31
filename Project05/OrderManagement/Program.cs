using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Data;
using OrderManagement.Implements;
using OrderManagement.Models;
using OrderManagement.Repositories;
using OrderManagement.Services;

var services = new ServiceCollection();

services.AddDbContext<OrderDbContext>();

services.AddScoped<IOrderRepository,OrderRepository>();

services.AddScoped<IProductRepository,ProductRepository>();
services.AddScoped<IOrderService,OrderService>();

var serviceProvider = services.BuildServiceProvider();


using(var scope = serviceProvider.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<OrderDbContext>();
    dbContext.Database.EnsureCreated();

    var productRepo = scope.ServiceProvider.GetRequiredService<IProductRepository>();
    await productRepo.AddAsync(new Product { Name = "Laptop", Price = 1500 });
    await productRepo.AddAsync(new Product { Name = "Phone", Price = 800 });

 
    var orderRepo = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
    var products = await productRepo.GetAllAsync();

    var order = new Order { CustomerName = "John Doe", OrderDate = DateTime.Now };
    foreach (var product in products)
    {
        order.orderDetails.Add(new OrderDetail
        {
            ProductId = product.Id,
            Quantity = 2
        });
    }
    await orderRepo.AddAsync(order);
}


var orderService = serviceProvider.GetRequiredService<IOrderService>();
var ordersWithProducts = await orderService.GetOrdersWithProductsAsync();


// await orderService.AddOrderAsync("John Doe", DateTime.Now, 150.50m);
// await orderService.AddOrderAsync("Jane Smith", DateTime.Now.AddDays(-1), 300.00m);

//var orders = await orderService.GetOrdersAsync();
foreach (var order in ordersWithProducts)
{
    Console.WriteLine($"Order ID: {order.Id}, Customer: {order.CustomerName}");
    foreach (var detail in order.orderDetails)
    {
        Console.WriteLine($"  Product: {detail.Product.Name}, Quantity: {detail.Quantity}, Price: {detail.Product.Price}");
    }
}