using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public class USABody : IBody
    {
        public void CreateBody()
        {
            Console.WriteLine("USA Body Created.");
        }
    }
}