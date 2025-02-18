using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands
{
    public abstract class MessageCode
    {
        public MessageCode(string Prefix, int Code)
        {
            Prefix = Prefix;
            Code = Code;   
        }

        public string Prefix {get; set;}
        public int Code {get; set;}      
    }
}