using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract;

namespace APIAuthenticationTest.API.Contracts
{
    public class SignInCommand:Command
    {
        public string UserName { get; set; }  // Username or email for login
        public string Password { get; set; }  // User password   
    }
}