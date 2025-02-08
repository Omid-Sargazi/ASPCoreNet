using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces.Implements
{
    public class ToyotaSedan : ISedan
    {
        public void Create()
        {
            Console.WriteLine("Toyota with Sedan features");
        }
    }
}