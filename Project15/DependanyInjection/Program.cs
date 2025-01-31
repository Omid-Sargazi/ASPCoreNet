using DependanyInjection.Implements;
using DependanyInjection.Repositories;
using DependanyInjection.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddTransient<IProductRepository,ProductRepository>();
        builder.Services.AddTransient<IProductService, ProductService>();

        var app = builder.Build();
        
        app.MapGet("/",(IProductService service)=>{
            var products = service.GetAllProducts();
            return Results.Ok(products);
        });

        app.Run();
    }
}