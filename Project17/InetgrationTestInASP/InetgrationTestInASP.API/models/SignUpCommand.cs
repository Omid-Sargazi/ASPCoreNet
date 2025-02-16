using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InetgrationTestInASP.API.models
{
    public class SignUpCommand
    {
        public string Email {get; set;}
        public string UserName {get; set;}
        public string Password {get; set;}
    }
}