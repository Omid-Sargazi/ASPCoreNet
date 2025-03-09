using System.Security.Cryptography.X509Certificates;
using MiddlewareProblems.MiddleWareProblems;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();

        if(app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }


        app.Use(async(context, next)=>{
            await context.Response.WriteAsync("Middleware 1;");
            await next();
            await context.Response.WriteAsync("Middleware 2;");
        });

        app.Run(async(context)=>{
            await context.Response.WriteAsync("Hello from final Middleware");
        });

        app.useSimpleLogging();

        app.Run();
    }

   
}