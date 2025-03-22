using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.WeatherApi
{
    public interface IWeatherService
    {
        public string GetWeather();
    }
}