using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowCopy.Users
{
    public class DeepCopyUser
    {
        public string Name {get; set;}
        public DeepCopyProfile DeepCopyProfile {get; set;}

        public DeepCopyUser DeepCopy()
        {
            return new DeepCopyUser {
                Name = this.Name,
                DeepCopyProfile = this.DeepCopyProfile.DeepCopy(),
            };
        }
    }
}