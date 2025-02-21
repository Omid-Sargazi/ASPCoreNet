public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();

        app.Use(async (context, next)=>{
            Console.WriteLine($"Incoming request: {context.Request.Method} {context.Request.Path}");
            await next();
        });

        app.MapGet("/",()=> "Hello World");
        // app.MapGet("/about",()=>"this is about page");

        // app.MapGet("/user",()=> new{Name = "Omid", Age=42});

        app.Run();
    }
}