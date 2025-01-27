using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern02.Interfaces;

namespace FactoryPattern02
{
    public class Application
    {
        private readonly ISedan _sedan;
        private readonly ISUVModel _suvModel;

        public Application(IModels models)
        {
            _sedan = models.createSedan();
            _suvModel = models.createSUVModel();
        }

        public void Created()
        {
            _sedan.Engine();
            _sedan.Capacity();
            _suvModel.Engine();
            _suvModel.Capacity();
        }
    }
}