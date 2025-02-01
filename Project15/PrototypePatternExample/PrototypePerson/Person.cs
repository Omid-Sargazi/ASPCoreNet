using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.PrototypePerson
{
    public class Person : ICloneable
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public Address Address {get; set;}

        public Person(string name, int age, Address address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public Person shallowCopy()
        {
            return (Person)this.Clone();
        }
        public object Clone()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.Address = this.Address.DeepCopy();
            return clone;
        }

        public override string ToString()
        {
            return $"Name: {Name},Age: {Age},Address: {Address}";
        }
    }
}