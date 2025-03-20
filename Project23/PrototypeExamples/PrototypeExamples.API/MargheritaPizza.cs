using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API
{
    public class MargheritaPizza : Pizza
    {
        public MargheritaPizza()
        {
            Name = "Margherita";
            Toppings.Add("Tomato Sauce");
            Toppings.Add("Mozzarella Cheese");
            Toppings.Add("Basil");
        }

        public override Pizza Clone()
        {
            return (Pizza)this.MemberwiseClone();
        }
    }
}