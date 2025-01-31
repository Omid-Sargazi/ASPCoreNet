using ProxyCachingAPIService.Interfaces;
using ProxyCachingAPIService.Proxies;
using ProxyCachingAPIService.Services;

public class Program
{
    public static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddSingleton<IProductService,ProductService>();
        // builder.Services.AddSingleton<IProductService,ProductServiceProxy>();
        builder.Services.AddSingleton<IProductService>(provider=>   
            new ProductServiceProxy(provider.GetRequiredService<IProductService>())
        );
        // builder.Services.AddEndpointsApiExplorer();

        var app = builder.Build();

     app.MapGet("/products", async (IProductService productService) =>
    {
    var products = await productService.GetProductsAsync();
    Console.WriteLine("products.Count");
    return Results.Ok(products);
    });


        app.Run();
    }
}