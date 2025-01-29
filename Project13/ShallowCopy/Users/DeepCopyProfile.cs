using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowCopy.Users
{
    public class DeepCopyProfile
    {
        public string DeepCopyAddress {get; set;}

        public DeepCopyProfile DeepCopy()
        {
            return new DeepCopyProfile {
                DeepCopyAddress = this.DeepCopyAddress  
            };
        }
    }
}