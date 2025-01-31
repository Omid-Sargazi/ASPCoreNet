// using PrototypePatternExample.Models;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("hello");

//         var builder = WebApplication.CreateBuilder(args);
//         builder.Services.AddSingleton<SessionManager>();
//         builder.Services.AddSingleton<UserSession>();
//         builder.Services.AddOpenApi();
//         builder.Services.AddEndpointsApiExplorer();
//         builder.Services.AddSwaggerGen();

//         var app = builder.Build();

//         app.UseSwagger();
//         app.UseSwaggerUI();


//         app.MapGet("/", (SessionManager sessionManger)=>{
//             var session = sessionManger.CreateSession(
//                 "Omid",
//                 new List<string>{"Admin","Editor"},
//                 new Dictionary<string, string>{{"theme","Dark"},{"Language", "English"}}
//             );
//             return Results.Ok(session);
//         });

//         using(var scope = app.Services.CreateScope())
//         {
//             Console.WriteLine("Hello");
//             // var sessionManager = scope.ServiceProvider.GetRequiredService<SessionManager>();
//             // Console.WriteLine(sessionManager);
//         }

//         app.Run();
//     }
// }


using PrototypePatternExample.Models;
using PrototypePatternExample.Users;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddOpenApi();
        builder.Services.AddSingleton<CreateUsers>();
        builder.Services.AddSingleton<CreateUserManager>();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.MapGet("/",(CreateUserManager createUserManager)=>{
            var newUser = createUserManager.createUsers(
                "Omid",
                new List<string>{"Admin"},
                new Dictionary<string, string>{{"Theme","light"},{"Language","French"}}
            );
            return Results.Ok(newUser);
        });

        using(var scope = app.Services.CreateScope())
        {
            Console.WriteLine("I'm in scope");
            var baseTemplate = new EmailTemplate("Welcome to our store","@2023 Mystore")
            {
                Subject = "Default subject",
                Body = "Dafault body"
            };

            var orderConfirmationEmail = (EmailTemplate)baseTemplate.Clone();
            orderConfirmationEmail.Subject = "Your order has been confirimed.";
            orderConfirmationEmail.Body = "Thank you for your purches.";
            orderConfirmationEmail.Send("Omid");
        }

        using(var scope = app.Services.CreateScope())
        {
            var baseEnemy = new GameCharacter("Goblin",100,"Sword");
            
            var enemy1 = (GameCharacter)baseEnemy.Clone();
            enemy1.Name = "Goblin 1";
            enemy1.Weapon = "Axe";

            enemy1.Display();
            baseEnemy.Display();
        }

        app.Run();

    }
}