using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;

namespace BasicCommandResponse.Users
{
    public class RegisterUserCommand:Command
    {
        public string UserName {get; set;}
        public string Password {get; set;}

        public RegisterUserCommand(string username, string password)
        {
            UserName = username;
            Password= Password;
        }
    }
}