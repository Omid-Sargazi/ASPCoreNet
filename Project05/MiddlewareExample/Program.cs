using MiddlewareExample;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<LoggingMiddleware>();

app.MapGet("/", () => "Hello World!");

app.Run();
