public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");
       var builder = WebApplication.CreateBuilder();

       var app = builder.Build();

       app.UseDeveloperExceptionPage();
       app.UseStaticFiles();

       app.Use(async (context, next)=>{
        Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
        await next();
       });

       app.Use(async (context, next)=>{
        await next();
        if(!context.Response.HasStarted)
            await context.Response.WriteAsync("Middleware says: Welcome!");
        
        // await next();
       });

       app.MapGet("/",()=>"Hello World");

       app.MapGet("/index",async context=>{
        await context.Response.SendFileAsync("wwwroot/index.html");
       });

       app.MapGet("/about",()=>"this is about page");

       app.MapGet("/user",() => new {Name = "Omid", Age=42});

       app.MapGet("/greet",(string name)=>{
        return $"Hello {name}";
       });

       app.MapGet("/user/{id}",(int id)=>{
        return new {UserId = id, Name = "Omid", Age=42};
       });

       app.MapPost("/user",(User user)=>{
        return new {Message = $"User {user.Name}", user};
       });

       app.Run();

    }


    public record User(string Name, int Age);
}