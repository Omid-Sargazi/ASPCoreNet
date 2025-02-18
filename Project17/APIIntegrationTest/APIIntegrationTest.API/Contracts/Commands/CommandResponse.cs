using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands
{
    public class CommandResponse
    {
       public CommandResponse()
       {
        
       }
       public CommandResponse(ResponseMessageCode messageCode)
       {
            Prefix = messageCode.Prefix;
            Code = messageCode.Code;
            Message = messageCode.Message;
       }

        public string Prefix {get; set;}
        public int Code {get; set;}
        public string Message {get; set;}        


    }
}