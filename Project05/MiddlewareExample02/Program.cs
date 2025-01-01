// using MiddlewareExample02.Middlewares;

// Console.WriteLine("Hello");

// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.UseMiddleware<LoggingMiddleware>();

// app.MapGet("/",()=>"Hello from Middlerware");

// app.Run();




using MiddlewareExample02.Configurations;
using MiddlewareExample02.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<LoggingOptions>(
    builder.Configuration.GetSection("LoggingOptions")
);

var app = builder.Build();

app.UseMiddleware<LoggingMiddleware02>();

app.MapGet("/",()=>"Hello, Configure MiddleWare");

app.Run();
