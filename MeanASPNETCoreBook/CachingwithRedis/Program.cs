using CachingwithRedis.Data;
using CachingwithRedis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Swashbuckle.AspNetCore.Swagger;
public class Program
{
public static void Main(string[] args)
    {

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddDbContext<AppDbContext>(options=> options.UseSqlite("Data Source=app.db"));


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
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    using(var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        db.Database.EnsureCreated();

        if(!db.Products.Any())
        {
            db.Products.AddRange(
                new Product {Name = "Laptop", Price=999.99m, Description = "High Performance"},
                new Product {Name = "Phone", Price=599.99m, Description = "Last smartphone"},
                new Product {Name = "Tablet", Price=399.99m, Description = "portable tablet"}
            );
            db.SaveChanges();
        }
    }

    app.Run();
    }
}