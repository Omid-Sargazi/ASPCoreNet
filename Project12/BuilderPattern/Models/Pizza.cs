using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class Pizza
    {
        public string Size {get; set;}
        public string Crust {get; set;}
        public List<string> Toppings = new List<string>();
        

        public void Display()
        {
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Crust: {Crust}");
            Console.WriteLine("Toppings: " + string.Join(", ", Toppings));
        }
    }
}