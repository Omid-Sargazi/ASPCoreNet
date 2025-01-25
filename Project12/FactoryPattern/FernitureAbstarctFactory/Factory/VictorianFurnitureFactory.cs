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
    public class VictorianFurnitureFactory : IFactoryFernuture
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISopha CreateSofa()
        {
            return new VictorianSofa();
        }

        public ITable Createtable()
        {
            return new VictorianTable();
        }
    }
}