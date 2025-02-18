using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands.Authentication
{
    public class SignInCommandResponse :CommandResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string ExpiredAt { get; set; }
        public string? ApplicantUnitName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyRole { get; set; }   
    }
}