using Microsoft.Extensions.Caching.StackExchangeRedis;
using Swashbuckle.AspNetCore.Swagger;
public class Program
{
    public static void Main(string[] args)
    {

var builder = WebApplication.CreateBuilder(args);

// Add Redis distributed caching
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
    options.InstanceName = "RedisCachingExample_";
});

// Add in-memory caching (optional)
builder.Services.AddMemoryCache();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    // app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
    }
}