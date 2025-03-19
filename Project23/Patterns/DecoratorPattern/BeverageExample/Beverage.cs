using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.DecoratorPattern.BeverageExample
{
    public abstract class Beverage
    {
        public string Description {get; set;} = "Unknown Beverage";
        public abstract double Cost();
    }
}