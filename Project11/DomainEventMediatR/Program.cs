// using System.Reflection;

// var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

// // Add services to the container.
// // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();

// var app = builder.Build();

// // Configure the HTTP request pipeline.

// app.MapGet("/", () => "MediatR Integration Complete!");

// app.Run();


using System.Reflection;
using DomainEventMediatR.Aggregates;
using MediatR;

class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

       builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

       var services = new ServiceCollection();
       var provider = services.BuildServiceProvider();
        var mediator = provider.GetRequiredService<IMediator>();

        var orderId = Guid.NewGuid();
        var customerId = Guid.NewGuid();
        var address = new Address("123 Main St", "New York", "10001");

        var items = new List<OrderItem>
        {
            new OrderItem(Guid.NewGuid(), "Laptop", 1, new Money(1500, "USD"))
        };

        var order = new Order(orderId, customerId, address, items);

        // Dispatch events via MediatR
        foreach (var domainEvent in order.DomainEvents)
        {
            await mediator.Publish(domainEvent);
        }

        // Clear events to avoid duplication
        order.ClearDomainEvents();

        // Add services to the container.
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.MapGet("/", () => "MediatR Integration Complete!");

        app.Run();
    }
}