using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowCopy.DeepCopy
{
    public class DeepPerson
    {
        public string Name {get; set;}
        public DeepAddress deepAddress {get; set;}

        public DeepPerson DeepCopy()
        {
            return new DeepPerson 
            {
                Name = this.Name,
                deepAddress = this.deepAddress.DeepCopy(),
            };
        }

    }
}