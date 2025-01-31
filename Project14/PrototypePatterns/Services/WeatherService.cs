using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrototypePatterns.weatherForecastingApplication;

namespace PrototypePatterns.Services
{
    public class WeatherService
    {
        private readonly WeatherData _weatherData;

        public WeatherService()
        {
            _weatherData = FetchWeatherDataAsync().Result;
        }

        public WeatherData GetWeatherData()
        {
            return (WeatherData)_weatherData.Clone();
        }


        private async Task<WeatherData> FetchWeatherDataAsync()
        {
            await Task.Delay(1000);
            return new WeatherData(45,82);
        }
        

    }
}