using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.WeatherApi
{
    public class WeatherAdapter : IWeatherService
    {
        private readonly object _weatherApi;
        public WeatherAdapter(object weatherApi)
        {
            _weatherApi = weatherApi;
        }

        public string GetWeather()
        {
            if(_weatherApi is OldWeatherApi oldWeatherApi)
            {
                return oldWeatherApi.FetchWeatherData();
            }

            if(_weatherApi is NewWeatherApi newWeatherApi)
            {
                return newWeatherApi.GetForecast();
            }

            throw new NotSupportedException("API not supported");
        }
    }
}