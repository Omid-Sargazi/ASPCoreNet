using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Season4.Models
{
    public class User
    {
         public int UserId { get; set; }
        public string Name { get; set; }
        public UserProfile Profile {get; set;}
    }
}