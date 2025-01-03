var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();//Active 
app.UseEndpoints(endpoints=>{
    //exceute endpoint.
});

// app.MapGet("/", () => "Hello World!");

app.Run();
