// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast")
// .WithOpenApi();

// app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }

























// var builder = WebApplication.CreateBuilder(args);

// var app = builder.Build();

// app.Use(async(context,next)=>{
//     Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
//     await next();
// });


// app.Use(async(context,next)=>{
//     if(!context.Request.Headers.ContainsKey("AuthToken"))
//         {
//          context.Response.StatusCode=401;   
//         await context.Response.WriteAsync("Authentication Failed: Missing AuthToken");
//         }

//         else if(context.Request.Headers["AuthToken"]!="ValidToken")
//         {
//             context.Response.StatusCode = 403; // Forbidden
//         await context.Response.WriteAsync("Authentication Failed: Invalid AuthToken");
//         }
//         else
//     {
//         await next(); // Pass to the next middleware
//     }
// });

// app.Run(async context =>
// {
//     await context.Response.WriteAsync("Welcome! You have successfully accessed the application.");
// });

// app.Run();






using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.Use(async(context,next)=>{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
});

app.Use(async(context,next)=>{
    var stopwatch = Stopwatch.StartNew();
    await next();
    stopwatch.Stop();
    Console.WriteLine($"Request Duration: {stopwatch.ElapsedMilliseconds} ms");
    });

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello! This response was timed.");
});

app.Run();














































































