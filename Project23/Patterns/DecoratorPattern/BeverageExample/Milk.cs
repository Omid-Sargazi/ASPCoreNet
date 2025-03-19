using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.DecoratorPattern.BeverageExample
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }

       public  string Description => _beverage.Description + ", Milk";

        public override double Cost()
        {
            return _beverage.Cost() + 0.9;
        }
    }
}