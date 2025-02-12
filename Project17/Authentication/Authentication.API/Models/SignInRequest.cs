using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Authentication.API.Models
{
    public class SignInRequest
    {
        public string Email {get; set;}
        public string Password {get; set;}
        public bool RememberMe {get; set;}
    }
}