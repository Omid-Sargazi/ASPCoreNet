var builder =WebApplication.CreateBuilder(args);

var app = builder.Build();


app.Use(async (HttpContext context,RequestDelegate next)=>{
    await context.Response.WriteAsync("Test01");
    await next(context);
});
app.Use(async (HttpContext context,RequestDelegate next)=>{
    await context.Response.WriteAsync("Hello World!");///show test for each request....
    await next(context);
});

app.Run(async (HttpContext context)=>{
    await context.Response.WriteAsync("Test02");
});


app.Run();