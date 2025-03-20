using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API
{
    public abstract class Pizza
    {
        public string Name {get; set;} = "Unknown Pizza";
        public List<string> Toppings {get; set;} = new();  

        public abstract Pizza Clone(); 
    }
}