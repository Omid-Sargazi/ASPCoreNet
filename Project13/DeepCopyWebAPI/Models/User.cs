using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepCopyWebAPI.Models
{
    public class User
    {
        public string Name {get; set;}
        public string Email {get; set;}
        public Profile Profile {get; set;}   
    }
}