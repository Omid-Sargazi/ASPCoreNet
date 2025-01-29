using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowCopy.DeepCopy02
{
    public class DeepCopyAddress
    {
        public string City {get; set;}

        public DeepCopyAddress DeepCopy()
        {
            return new DeepCopyAddress{City = this.City};
        }
    }
}