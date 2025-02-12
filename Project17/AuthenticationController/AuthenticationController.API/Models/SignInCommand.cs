using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationController.API.Models
{
    public class SignInCommand:Command
    {
        public string UserName {get; set;}
        public string Password {get; set;}
        public bool IsPersistent {get; set;}
        public SignInCommand(string username, string password, bool isPersistent)
        {
            UserName = username;
            Password = password;
            IsPersistent = isPersistent;
        }
    }
}