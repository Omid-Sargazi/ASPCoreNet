using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern02.Interfaces
{
    public interface IModels
    {
        public ISedan createSedan();
        public ISUVModel createSUVModel();
    }
}