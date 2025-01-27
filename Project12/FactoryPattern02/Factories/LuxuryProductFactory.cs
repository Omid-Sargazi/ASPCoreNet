using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern02.Interfaces;

namespace FactoryPattern02.Factories
{
    public class LuxuryProductFactory : IModels
    {
        public ISedan createSedan()
        {
            return new SedanLuxury();
        }

        public ISUVModel createSUVModel()
        {
            return new SUVModelLuxury();
        }
    }
}