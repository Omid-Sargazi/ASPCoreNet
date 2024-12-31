using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Data;
using OrderManagement.Implements;
using OrderManagement.Repositories;
using OrderManagement.Services;

var services = new ServiceCollection();

services.AddDbContext<OrderDbContext>();

services.AddScoped<IOrderRepository,OrderRepository>();

services.AddScoped<IOrderService,OrderService>();

var serviceProvider = services.BuildServiceProvider();


using(var scope = serviceProvider.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<OrderDbContext>();
    dbContext.Database.EnsureCreated();
}


var orderService = serviceProvider.GetRequiredService<IOrderService>();


await orderService.AddOrderAsync("John Doe", DateTime.Now, 150.50m);
await orderService.AddOrderAsync("Jane Smith", DateTime.Now.AddDays(-1), 300.00m);

var orders = await orderService.GetOrdersAsync();
foreach (var order in orders)
{
    Console.WriteLine($"ID: {order.Id}, Customer: {order.CustomerName}, Date: {order.OrderDate}, Total: {order.TotalAmount}");
}