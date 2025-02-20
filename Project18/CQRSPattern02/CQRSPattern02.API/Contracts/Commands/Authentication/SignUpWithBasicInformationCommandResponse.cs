using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern02.API.Contracts.Commands.Authentication
{
    public class SignUpWithBasicInformationCommandResponse
    {
        public bool Succeeded {get; set;}
        public string Message {get; set;}
        public string UserId {get; set;}
        public IEnumerable<string> Errors {get; set;}
    }
}