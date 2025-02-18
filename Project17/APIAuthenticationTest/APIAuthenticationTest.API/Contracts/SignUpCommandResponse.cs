using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract;

namespace APIAuthenticationTest.API.Contracts
{
    public class SignUpCommandResponse :CommandResponse
    {
        public bool IsSuccessful { get; set; }  // Indicates success or failure   
    }
}