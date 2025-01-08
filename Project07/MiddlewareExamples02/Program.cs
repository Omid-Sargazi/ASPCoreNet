using MiddlewareExamples02.Middlewares;

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




app.MapGet("/", () => "Hello World!");


app.Run();
