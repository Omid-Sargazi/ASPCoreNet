using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public class USAEngine : IEngine
    {
        public void CreateEngine()
        {
            Console.WriteLine("USA Engine Created.");
        }
    }
}