using MiddlewareExample02.Middlewares;

Console.WriteLine("Hello");

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<LoggingMiddleware>();

app.MapGet("/",()=>"Hello from Middlerware");

app.Run();