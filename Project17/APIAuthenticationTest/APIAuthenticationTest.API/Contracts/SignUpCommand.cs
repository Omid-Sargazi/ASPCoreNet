using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract;

namespace APIAuthenticationTest.API.Contracts
{
    public class SignUpCommand:Command
    {
        public string UserName { get; set; }  // Required username
        public string Email { get; set; }     // Required email
        public string Password { get; set; }  // User password
        public string ConfirmPassword { get; set; } // Password confirmation
    }
}