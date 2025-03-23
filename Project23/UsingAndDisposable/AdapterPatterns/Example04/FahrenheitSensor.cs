using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example04
{
    public class FahrenheitSensor
    {
        public double GetTemperatureInFahrenheit()
        {
            return 98.6;
        }
    }
}