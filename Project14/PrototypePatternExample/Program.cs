using PrototypePatternExample.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");

        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddSingleton<SessionManager>();
        builder.Services.AddSingleton<UserSession>();
        builder.Services.AddOpenApi();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();


        app.MapGet("/", (SessionManager sessionManger)=>{
            var session = sessionManger.CreateSession(
                "Omid",
                new List<string>{"Admin","Editor"},
                new Dictionary<string, string>{{"theme","Dark"},{"Language", "English"}}
            );
            return Results.Ok(session);
        });

        using(var scope = app.Services.CreateScope())
        {
            Console.WriteLine("Hello");
        }

        app.Run();
    }
}