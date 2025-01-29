using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowCopy.Users
{
    public class User
    {
        public string Name {get; set;}
        public Profile Profile {get; set;}

        public User ShallowCopy()
        {
            return(User)this.MemberwiseClone();
        }
    }
}