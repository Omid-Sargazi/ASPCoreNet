using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public interface IVehicleFactory
    {
        public IBody CreateBody();
        public ISuspension CreateSuspension();
        public IEngine CreateEngine();
    }
}