using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Season4.Models
{
    public class UserProfile
    {
        public int UserProfileId {get; set;}
        public string Bio {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}
    }
}