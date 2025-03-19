using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.DecoratorPattern.BeverageExample
{
    public class HouseBlend:Beverage
    {
        public HouseBlend()
    {
        Description = "House Blend Coffee";
    }

    public override double Cost()
    {
        return 0.89; // Base price
    }
    }
}