using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public class USAVehicleFactory : IVehicleFactory
    {
        public IBody CreateBody()
        {
            return new USABody();
        }

        public IEngine CreateEngine()
        {
            return new USAEngine();
        }

        public ISuspension CreateSuspension()
        {
            return new USASuspension();
        }
    }
}