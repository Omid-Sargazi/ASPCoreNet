using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public class EuropeSuspension:ISuspension
    {
        public void CreateSuspension()
        {
            Console.WriteLine("Europe Suspension Created");
        }
    }
    
}