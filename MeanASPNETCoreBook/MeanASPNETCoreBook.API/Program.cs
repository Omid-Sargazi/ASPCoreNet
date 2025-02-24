using MeanASPNETCoreBook.API.Projects;
namespace MeanASPNETCoreBook.API
{
    public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddSingleton<UserService>();
        // builder.Services.AddSwaggerGen();

        builder.Services.AddControllers();
        var app = builder.Build();

        app.MapControllers();


        // app.MapGet("/hello", ()=>"Hello from asp.net core");
        // app.MapGet("/jsonfile",()=>
        //     new {Name ="Omid", Age=42}
        // );

        // app.MapGet("/about",()=>{return new {page="About", title="About us"};});

        // app.MapGet("/greet",(string name)=>{
        //     return $"Hello {name}";
        // });

        // app.MapGet("/user/{id}",(int id)=>{
        //     return $"squere is {id*id}";
        // });


        // app.MapPost("/postUser",(User user)=>{
        //     return $"Hello {user.name} {user.age}";
        // });


        // app.MapPost("/postUser2",(User user)=>{
        //     return new {name=user.name, age=user.age};
        // });

        // app.MapGet("/userServices",(UserService services)=>{
        //     return services.GetUsers();
        // });

        // app.UseSwagger();
        // app.UseSwaggerUI();

        //Day 6
        // app.MapGet("/products",()=> 
        //     new List<Product> {
        //         new Product(1, "Laptop", 1200),
        //         new Product(2, "Phone", 500),
        //     }
        // );

        // app.MapGet("/products/{id}",(int id)=>{
        //     var products = new List<Product>
        //     {
        //         new Product(1, "Laptop",1200),
        //         new Product(2, "Phone", 800)
        //     };

        //     var product = products.FirstOrDefault(p => p.Id == id);
        //     return product is null ? Results.NotFound("Product not found") : Results.Ok(product);
        // });

        // app.MapGet("/search",(string Name)=>{
        //     var products = new List<Product> 
        //     {
        //         new Product(1, "Laptop", 1200),
        //         new Product(2, "Phone", 800)
        //     };

        //     var foundProducts = products.Where(p => p.Name.Contains(Name,StringComparison.OrdinalIgnoreCase)).ToList();
        //     return Results.Ok(foundProducts);
        // });



        app.Run();
    }


    // public record User(string name, int age);

    // public record Product(int Id, string Name, decimal Price);
}
   
}
