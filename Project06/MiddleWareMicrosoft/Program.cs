var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next)=>{
    Console.WriteLine("Before MiddleWare 1.");
    await next();
    Console.WriteLine("After Middleware 1.");
});


app.Use(async(context, next)=>{
    Console.WriteLine("Before Middleware 2.");
    await next();
    Console.WriteLine("After Middleware 2.");
});

app.Use(async (context,next)=>{
    Console.WriteLine("Before Middleware 3.");
    await next();
    Console.WriteLine("After Middleware 3.");
});

app.Run(async(context)=>{
    Console.WriteLine("Inside Terminal Middleware");
    await context.Response.WriteAsync("Hello World!");
});

app.MapGet("/", () => "Hello World!");

app.Run();
