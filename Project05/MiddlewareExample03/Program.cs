using MiddlewareExample03.MiddleWares;

var builder =WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MiddleWare01>();
var app = builder.Build();


// app.UseMiddleware<MiddleWare01>();
app.ExtentionMethod();

app.Use(async (HttpContext context,RequestDelegate next)=>{
    await context.Response.WriteAsync("Test01");
    await next(context);
});
app.Use(async (HttpContext context,RequestDelegate next)=>{
    await context.Response.WriteAsync("Hello World!");///show test for each request....
    await next(context);
    await context.Response.WriteAsync("Bye...");
});

app.Run(async (HttpContext context)=>{
    await context.Response.WriteAsync("Test02");
});


app.Run();