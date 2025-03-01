using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.VehicleManufacturingSystem
{
    public class Application
    {
        private readonly IBody _body;
        private readonly IEngine _engine;
        private readonly ISuspension _suspension;

        public Application(IVehicleFactory factory)
        {
            _body = factory.CreateBody();
            _engine = factory.CreateEngine();
            _suspension = factory.CreateSuspension();
        }

        public void CreateVehicle()
        {
            _body.CreateBody();
            _engine.CreateEngine();
            _suspension.CreateSuspension();
        }
    }
}