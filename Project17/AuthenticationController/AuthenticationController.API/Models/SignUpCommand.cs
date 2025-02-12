using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationController.API.Models
{
    public class SignUpCommand:Command
    {
        public SignUpCommand(string username, string password, string email)
        {
            UserName = username;
            Password = password;
            Email = email;
        }
        public string UserName {get; set;}
        public string Password {get; set;}
        public string Email {get; set;}
    }
}