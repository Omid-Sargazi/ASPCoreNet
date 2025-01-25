using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class PizzaDirector
    {
        private IPizzaBuilder _builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public void MakePizza()
        {
            _builder.SetSize("Large");
            _builder.SetCrust("Thin");
            _builder.AddTopping("Cheese");
            _builder.AddTopping("Pepperoni");
            _builder.AddTopping("Sausage");
        }
    }
}