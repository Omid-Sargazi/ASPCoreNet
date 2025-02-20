using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern02.API.Contracts.Commands.Authentication
{
    public class SignOutCommandResponse 
    {
        public string Message {get; set;}
        public bool Succeeded {get; set;}   
    }
}