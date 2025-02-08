using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.CarBuilder
{
    public class Car
    {
        public string Brand {get; set;}
        public string Model {get; set;}
        public string Engine {get; set;}
        public string Color {get; set;}
        public string Wheels {get; set;}
        public bool Sunroof {get; set;}
        public bool GPS {get; set;}

        public void ShowDetails()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine:{Engine}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Wheels:{Wheels}");
            Console.WriteLine(Sunroof? "Sunroof:true": "Sunroof: false");
            Console.WriteLine(GPS? "GPS:true": "GPS: false");
        }
    }
}