using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.WeatherApi
{
    public class OldWeatherApi
    {
        public string FetchWeatherData()
        {
            return "Sunny,25°C,10km/h";
        }
    }
}