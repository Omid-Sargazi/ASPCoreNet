using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.PrototypePerson
{
    public class Address
    {
        public string Street { get; set; }
        public string City {get; set;}

        public Address(string street, string city)
        {
            Street = street;
            City = city;    
        }

        public Address DeepCopy()
        {
            return new Address(this.Street, this.City);
        }

        public override string ToString()
        {
            return $"{Street}, {City}";
        }
    }
}