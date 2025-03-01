using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public class USASuspension : ISuspension
    {
        public void CreateSuspension()
        {
            Console.WriteLine("USA Suspension Created.");
        }
    }
}