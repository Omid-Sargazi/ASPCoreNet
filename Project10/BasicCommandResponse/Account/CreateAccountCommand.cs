using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;

namespace BasicCommandResponse.Account
{
    public class CreateAccountCommand:Command
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public CreateAccountCommand(string username, string password)
        {
            Password = password;
            username = username;
        }
    }
}