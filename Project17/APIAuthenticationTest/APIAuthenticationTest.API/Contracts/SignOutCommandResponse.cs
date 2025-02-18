using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract;

namespace APIAuthenticationTest.API.Contracts
{
    public class SignOutCommandResponse :CommandResponse
    {
        public string Message { get; set; } = "Successfully signed out.";
    }
}