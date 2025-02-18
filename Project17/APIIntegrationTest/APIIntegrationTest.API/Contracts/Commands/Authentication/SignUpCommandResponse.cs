using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands.Authentication
{
    public class SignUpCommandResponse:CommandResponse
    {
        public string Message {get; set;}
        public string Prefix {get; set;}
        public int Code {get; set;}
    }
}