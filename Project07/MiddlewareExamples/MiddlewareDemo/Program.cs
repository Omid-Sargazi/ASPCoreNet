var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.Use(async(context,next)=>{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response: {context.Response.StatusCode}");
});


app.Use(async(context,next)=>{
    if(!context.Request.Headers.ContainsKey("Authorization"))
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsync("Unauthorized");
        return;
    }
    await next();
});





















app.MapGet("/", () => "Logging Middleware!");

app.Run();
