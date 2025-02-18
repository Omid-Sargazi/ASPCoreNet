using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands.Authentication
{
    public class SignUpCommand:Command
    {
        public string UserName {get; set;}
        public string Password {get; set;}
        public string Email {get; set;}
    }
}