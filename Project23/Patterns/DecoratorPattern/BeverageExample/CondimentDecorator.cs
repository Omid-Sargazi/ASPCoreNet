using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.DecoratorPattern.BeverageExample
{
    public abstract class CondimentDecorator:Beverage
    {
        protected Beverage _beverage;
        public CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}