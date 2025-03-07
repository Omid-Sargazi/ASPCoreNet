using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggigMonitoringMatter.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoggigMonitoringMatter.Controllers
{
   [ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        Console.WriteLine("Helloooo");
        _logger.LogInformation("Weather forecast requested at {Time}", DateTime.UtcNow);
        
        // var forecast = Enumerable.Range(1, 5).Select(static index => new WeatherForecast
        // {
        //     Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //     TemperatureC = Random.Shared.Next(-20, 55),
        //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        // })
        // .ToArray();

        _logger.LogInformation("Weather forecast requested {@RequestInfo}", new {
            Time = DateTime.UtcNow,
            UserAgent = Request.Headers.UserAgent.ToString(),
            ClientIp = HttpContext.Connection.RemoteIpAddress,
        });

        try
        {
             var forecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();


          _logger.LogInformation("Generated weather forecast {@Forecast}", new {
            Count = forecast.Length,
            MinTemp = forecast.Min(f => f.TemperatureC),
            MaxTemp = forecast.Max(f => f.TemperatureC),
            Conditions = forecast.Select(f => f.Summary).Distinct()
        });
        
        return forecast;
        }
        catch (Exception ex)
        {
            
             _logger.LogError(ex, "Error generating weather forecast");
                throw;
        }
        
        // _logger.LogInformation("Generated {Count} weather forecasts", forecast.Length);
        
        // return forecast;
    }
}
}