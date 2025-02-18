using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands.Authentication
{
    public class SignInCommand:Command
    {
        public string UserName {get; set;}
        public string Password {get; set;}
        public bool IsPersistent {get; set;}   
    }
}