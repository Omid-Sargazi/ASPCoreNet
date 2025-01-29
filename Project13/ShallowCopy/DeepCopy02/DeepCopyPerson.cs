using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowCopy.DeepCopy02
{
    public class DeepCopyPerson
    {
        public string Name {get; set;}
        public DeepCopyAddress DeepCopyAddress {get; set;}

        public DeepCopyPerson DeepCopy()
        {
            return new DeepCopyPerson
            {
                Name = this.Name,
                DeepCopyAddress = this.DeepCopyAddress.DeepCopy(),
            };


        }
    }
}