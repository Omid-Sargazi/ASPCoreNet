using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.WeatherApi
{
    public class NewWeatherApi
    {
        public string GetForecast()
        {
            return "Cloudy, 22°C";
        }
    }
}