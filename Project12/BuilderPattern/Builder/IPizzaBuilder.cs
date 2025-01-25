using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPattern.Models;

namespace BuilderPattern.Builder
{
    public interface IPizzaBuilder
    {
        void SetSize(string size);
        void SetCrust(string crust);
        void AddTopping(string topping);
        Pizza GetPizza();       
    }
}