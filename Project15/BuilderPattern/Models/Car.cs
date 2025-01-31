using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class Car
    {
         public string Brand { get;  set; }
        public string Model { get;  set; }
        public int Year { get;  set; }
        public string Engine { get;  set; }

        public Car(){} // only Builder can create Car.

        public override string ToString()
        {
            return $"{Brand} {Model}, Year: {Year}, Engine: {Engine}";
        }
    }
}