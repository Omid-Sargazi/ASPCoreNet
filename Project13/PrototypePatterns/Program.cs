using PrototypePatterns.Mangers;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();


        app.MapGet("/login",(SessionManager sessioManger)=>{
            var session = sessioManger.CreateSession(
                "JohnDoe",
                new List<string>{"Admin", "Editor"},
                new Dictionary<string, string>{{"Theme","Dark"},{"language","English"}}
            );

            return Results.Ok(session);
        });




        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();



        app.Run();

    }
}