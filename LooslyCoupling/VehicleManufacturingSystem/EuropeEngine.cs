using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public class EuropeEngine : IEngine
    {
        public void CreateEngine()
        {
            Console.WriteLine("Europe Engine Created.");
        }
    }
}