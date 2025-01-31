using PrototypePatterns.Services;
using PrototypePatterns.weatherForecastingApplication;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Weaher application");

        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddSingleton<WeatherService>();
        // builder.Services.AddSingleton<WeatherData>();


        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddOpenApi();

        var app = builder.Build();

        app.MapGet("/",(WeatherService weatherService)=>{
            var weatherData = weatherService.GetWeatherData();
            weatherData.Temperature += 1;
            return Results.Ok(weatherData);
        });


        using(var scope = app.Services.CreateScope())
        {
            Console.WriteLine("App");
            WeatherService weatherService = scope.ServiceProvider.GetRequiredService<WeatherService>();
            var weather = weatherService.GetWeatherData();
            weather.Temperature +=1;
            weather.Display();
            
        }
        app.Run();
    }
}