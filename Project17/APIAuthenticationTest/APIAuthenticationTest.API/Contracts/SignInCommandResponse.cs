using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract;

namespace APIAuthenticationTest.API.Contracts
{
    public class SignInCommandRespons:CommandResponse
    {
         public string Token { get; set; }       // JWT access token
        public string RefreshToken { get; set; } // Refresh token (to get a new JWT)
        public string ExpiredAt { get; set; }   // Expiration time for the token   
    }
}