var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


// app.Use(async(context,next)=>{
//     Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
//     await next();
//     Console.WriteLine($"Response: {context.Response.StatusCode}");
// });


// app.Use(async(context,next)=>{
//     if(context.Request.Headers.ContainsKey("Authorization"))
//     {
//         context.Response.StatusCode = 401;
//         await context.Response.WriteAsync("Unauthorized");
//         await next();
//         // return;
//     }
//     await next();
// });





// app.Use(async(context, next)=>{
//     try{
//         await next();
//     }
//     catch(Exception ex)
//     {
//          context.Response.StatusCode = 500;
//         await context.Response.WriteAsync($"Error: {ex.Message}");
//     }
// });

app.Use(async(context,next)=>{
    var start = DateTime.Now;
    await next();
    var processingTime = DateTime.UtcNow - start;
    context.Response.Headers.Add("X-Processing-Time", processingTime.TotalMilliseconds.ToString());
});



















app.MapGet("/", () => "Check the response headers for processing time!");

app.Run();
