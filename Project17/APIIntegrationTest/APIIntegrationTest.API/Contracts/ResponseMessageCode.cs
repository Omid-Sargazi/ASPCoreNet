using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIntegrationTest.API.Contracts.Commands;

namespace APIIntegrationTest.API.Contracts
{
    public class ResponseMessageCode : MessageCode
    {
        public ResponseMessageCode(string Prefix, int Code, string message) : base(Prefix, Code)
        {
            Message = message;
        }

        public string Message {get; set;}
    }
}