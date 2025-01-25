using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.FernitureAbstarctFactory.Implements.Chair;
using FactoryPattern.FernitureAbstarctFactory.Implements.Sofa;
using FactoryPattern.FernitureAbstarctFactory.Implements.Table;
using FactoryPattern.FernitureAbstarctFactory.Interfaces;

namespace FactoryPattern.FernitureAbstarctFactory.Factory
{
    public class ModernFurnitureFactory : IFactoryFernuture
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISopha CreateSofa()
        {
            return new ModernSofa();
        }

        public ITable Createtable()
        {
           return new ModernTable();
        }
    }
}