using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern02.API.Contracts.Markers;


namespace CQRSPattern02.API.Contracts.Commands.Authentication
{
    public class SignInCommand : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}