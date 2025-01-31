using DependanyInjection;
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


        var storageSettings = builder.Configuration.GetSection("StorageSettings").Get<StorageSettings>();

        builder.Services.AddTransient<IStorageService>(provider =>
{
    if (storageSettings.StorageType == "Local")
    {
        return new LocalStorageService(storageSettings.LocalStoragePath);
    }
    else if (storageSettings.StorageType == "Cloud")
    {
        return new CloudStorageService(storageSettings.CloudConnectionString);
    }
    else
    {
        throw new InvalidOperationException("Invalid storage type configured.");
    }
});


        var app = builder.Build();
        
        app.MapGet("/",(IProductService service)=>{
            var products = service.GetAllProducts();
            return Results.Ok(products);
        });

        app.Run();
    }
}