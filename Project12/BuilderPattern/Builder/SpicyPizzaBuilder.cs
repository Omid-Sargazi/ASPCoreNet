using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPattern.Models;

namespace BuilderPattern.Builder
{
    public class SpicyPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        public void AddTopping(string topping)
        {
            _pizza.Toppings.Add(topping);
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }

        public void SetCrust(string crust)
        {
            _pizza.Crust = crust;
        }

        public void SetSize(string size)
        {
            _pizza.Size = size;
        }
    }
}