var builder =WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run(async (HttpContext context)=>{
    await context.Response.WriteAsync("Hello World!");///show test for each request....
});


app.Run();