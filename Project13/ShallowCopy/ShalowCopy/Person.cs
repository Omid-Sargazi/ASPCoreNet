using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowCopy.ShalowCopy
{
    public class Person
    {
        public string Name {get; set;}
        public Address Address {get; set;}

        public Person ShalowCopy()
        {
            return(Person)this.MemberwiseClone();
        }
    }
}