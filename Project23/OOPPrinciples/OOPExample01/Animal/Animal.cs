using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPPrinciples.OOPExample01.Animal
{
    public class Animal
    {
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}