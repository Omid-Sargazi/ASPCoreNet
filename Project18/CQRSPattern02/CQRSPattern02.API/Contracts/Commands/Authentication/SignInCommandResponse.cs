using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern02.API.Contracts.Markers;

namespace CQRSPattern02.API.Contracts.Commands.Authentication
{
    public class SignInCommandResponse
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public string? Token { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}