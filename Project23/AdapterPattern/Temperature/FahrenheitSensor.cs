using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.Temperature
{
    public class FahrenheitSensor
    {
        public double GetTemperatureInFahrenheit()
        {
            return 98.6;
        }
    }
}