using MeanASPNETCoreBook.API.Projects;
namespace MeanASPNETCoreBook.API
{
    public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");
       var builder = WebApplication.CreateBuilder();

       builder.Services.AddSingleton<UserService>();
       builder.Services.AddSingleton<TodoService>();

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

       app.MapGet("/userss",(UserService service)=> service.GetUsers());

       app.MapGet("todos", (TodoService service) => service.GetTodos());
       app.MapPost("todos",(TodoService service, TodoItem item)=> service.AddTodo(item));

       app.Run();

    }


}
    public record User(string Name, int Age);

    public class UserService
    {
        private readonly List<User> _users = new()
        {
            new User ("Alice", 30),
            new User ("Bob", 25),
        };

        public List<User> GetUsers()=>_users;
    }
}
