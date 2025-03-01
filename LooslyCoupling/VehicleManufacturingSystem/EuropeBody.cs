using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public class EuropeBody : IBody
    {
        public void CreateBody()
        {
            Console.WriteLine("Europe Body Created.");
        }
    }
}