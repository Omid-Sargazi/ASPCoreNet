using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern02.Interfaces;

namespace FactoryPattern02.Factories
{
    public class EconomyProductFactory : IModels
    {
        public ISedan createSedan()
        {
            return new SedanEconomy();
        }

        public ISUVModel createSUVModel()
        {
            return new SUVModelEconomy();
        }
    }
}