
using FactoryPattern.FernitureAbstarctFactory.Implements.Chair;
using FactoryPattern.FernitureAbstarctFactory.Implements.Sofa;
using FactoryPattern.FernitureAbstarctFactory.Implements.Table;
using FactoryPattern.FernitureAbstarctFactory.Interfaces;

namespace FactoryPattern.FernitureAbstarctFactory.Factory
{
    public class ArtDecoFurnitureFactory : IFactoryFernuture
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ISopha CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public ITable Createtable()
        {
            return new ArtDecoTable();
        }
    }
}