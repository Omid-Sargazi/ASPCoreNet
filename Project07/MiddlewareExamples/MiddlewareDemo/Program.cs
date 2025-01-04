var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.Use(async(context,next)=>{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response: {context.Response.StatusCode}");
});






















app.MapGet("/", () => "Logging Middleware!");

app.Run();
