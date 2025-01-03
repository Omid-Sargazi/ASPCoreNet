using MiddleWareMicrosoft.MiddleWares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.Use(async (context, next)=>{
//     Console.WriteLine("Before MiddleWare 1.");
//     await next();
//     Console.WriteLine("After Middleware 1.");
// });


// app.Use(async(context, next)=>{
//     Console.WriteLine("Before Middleware 2.");
//     await next();
//     Console.WriteLine("After Middleware 2.");
// });

// app.Use(async (context,next)=>{
//     Console.WriteLine("Before Middleware 3.");
//     await next();
//     Console.WriteLine("After Middleware 3.");
// });

// app.Run(async(context)=>{
//     Console.WriteLine("Inside Terminal Middleware");
//     await context.Response.WriteAsync("Hello World!");
// });


//Short-Circuiting the Pipeline
// app.Use(async(context,next)=>{
//     if(context.Request.Path=="/stop")
//     {
//         await context.Response.WriteAsync("Pipeline Short-Circuited!");
//         return;
//     }
//     await next();

// });


// //Branches the pipeline based on the request path.
// app.Map("/path", appBuilder=>{
//     appBuilder.Run(async context=>{
//         await context.Response.WriteAsync("Hello from /path!");
//     });
// });
// app.Run(async(context)=>{
//     await context.Response.WriteAsync("Hello from Terminal Middleware!");
// });

//Register the Middleware
app.UseMiddleware<IPLoggerMiddleware>();
app.UseMiddleware<LoggingMiddleware>();

app.MapWhen(context=>context.Request.Query.ContainsKey("debug"),appBuilder=>{
    appBuilder.Run(async context=>{
        await context.Response.WriteAsync("Debug mode enabled!");
    });
});

app.Map("/amin",adminApp=>{
    adminApp.Run(async context=>{
        await context.Response.WriteAsync("Welcome to the admin section!");
    });
});

app.UseResponseCompression();

app.Use(async(context, next)=>{
    var largeData = new string('x',10000);
    await context.Response.WriteAsync(largeData);
    await next();
});

//API Key Validation Middleware

app.Run(async (context)=>{
    if(!context.Request.Headers.ContainsKey("X-API-KEY"))
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsync("API Key missing!");
        return;    
    }


});


app.UseStaticFiles();
app.Run(async context=>{
    await context.Response.WriteAsync("This will not be executed for static file requests.");
});

app.Run(async context=>{
    await context.Response.WriteAsync("Hello World!!!!!!!!!!!!!!!");
});


app.MapGet("/", () => "Hello World!");

app.Run();
