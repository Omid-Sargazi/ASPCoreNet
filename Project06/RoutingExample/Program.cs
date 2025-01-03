var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async(HttpContext context, RequestDelegate next) =>{
    Microsoft.AspNetCore.Http.Endpoint? endPoint = context.GetEndpoint();
    //Console.WriteLine($"Endpoint Name: {endPoint.DisplayName}");
    await next(context);
});

app.UseRouting();//Active 

app.Use(async (HttpContext context, RequestDelegate next) =>{
    Microsoft.AspNetCore.Http.Endpoint? endpoint=  context.GetEndpoint();
    if(endpoint !=null)
    {

    Console.WriteLine($"Endpoint Name: {endpoint.DisplayName}");
    await context.Response.WriteAsync($"Endpoint Name: {endpoint.DisplayName}"); 
    }

    await next(context);
});



app.UseEndpoints(endpoints=>{
    //exceute endpoint.
    endpoints.Map("/about", async (HttpContext context)=>{
        await context.Response.WriteAsync("About Us");
    });

    endpoints.MapPost("/contact",async (context)=>{
        await context.Response.WriteAsync("Contact Us");
    });

});

app.UseEndpoints(endpoints=>{
    endpoints.MapGet("/Home",async context=>{
        await context.Response.WriteAsync("Home Page");
    });
});

app.MapGet("/", () => "Hello World!");

app.Run(async (HttpContext context)=>{
    await context.Response.WriteAsync($"You are in Path:  {context.Request.Path}");
});

app.Run();
