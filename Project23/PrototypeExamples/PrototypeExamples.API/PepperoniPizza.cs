using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            Toppings.Add("Tomato Sauce");
            Toppings.Add("Mozzarella Cheese");
            Toppings.Add("Pepperoni");
        }

        public override Pizza Clone()
        {
            return (Pizza)this.MemberwiseClone();
        }
           
    }
}