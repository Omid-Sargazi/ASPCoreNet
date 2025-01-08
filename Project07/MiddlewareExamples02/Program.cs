using System.Reflection;
using FluentValidation;
using MediatR;
using MiddlewareExamples02.Exceptions;
using MiddlewareExamples02.Middlewares;
using MiddlewareExamples02.Requests;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseMiddleware<RequestLoggingMiddleware>();
// app.UseMiddleware<ResponseTimeMiddleware>();
//app.UseMiddleware<AuthenticationMiddleware>();
//app.UseMiddleware<IpWhitelistMiddleware>(new List<string>{"127.0.1.1"});
// app.UseMiddleware<CustomHeaderMiddleware>();
// app.UseMiddleware<RequestValidationMiddleware>();
app.UseMiddleware<RateLimitingMiddleware>();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());


app.MapGet("/", async (IMediator mediator)=>{
    
    var createOrderCommand = new CreateOrderCommand("Alice", "Laptop", 2);

    try
    {
        var orderId = await mediator.Send(createOrderCommand);
        return Results.Ok($"Order ID: {orderId}");
    }catch(ValidationException ex)
    {
        return Results.BadRequest($"Validation Failed: {ex.Message}");

    }
    catch(CustomException ex)
    {
        return Results.BadRequest($"Error: {ex.Message}");
    }
});


//app.MapGet("/", () => "Hello World!");


app.Run();
