using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.FernitureAbstarctFactory.Interfaces;

namespace FactoryPattern.FernitureAbstarctFactory.Factory
{
    public interface IFactoryFernuture
    {
        public IChair CreateChair();
        public ISopha CreateSofa();
        public ITable Createtable();
    }
}