using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public class EuropeVehicleFactory : IVehicleFactory
    {
        public IBody CreateBody()
        {
            return new EuropeBody();
        }

        public IEngine CreateEngine()
        {
            return new EuropeEngine();
        }

        public ISuspension CreateSuspension()
        {
            return new EuropeSuspension();
        }
    }
}