using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowCopy.DeepCopy
{
    public class DeepAddress
    {
        public string City {get; set;}


    public DeepAddress DeepCopy()
    {
        return new DeepAddress {City = this.City};
    }

    
    }

}