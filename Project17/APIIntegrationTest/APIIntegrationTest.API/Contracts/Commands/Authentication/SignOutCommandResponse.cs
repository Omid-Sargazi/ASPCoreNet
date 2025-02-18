using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands.Authentication
{
    public class SignOutCommandResponse :CommandResponse
    {
        public string Message {get; set;}   
    }
}