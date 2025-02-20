using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern02.API.Contracts.Markers;

namespace CQRSPattern02.API.Contracts.Commands.Authentication
{
    public class SignUpWithBasicInformationCommand:ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
    }
}