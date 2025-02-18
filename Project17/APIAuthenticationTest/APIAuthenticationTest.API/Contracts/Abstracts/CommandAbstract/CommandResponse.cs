using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract
{
    public abstract class CommandResponse
    {
        protected CommandResponse()
        {
            
        }

        public CommandResponse(ResponseMessageCode messageCode)
        {
            Prefix = messageCode.Prefix;
            Code = messageCode.Code;
            Message = messageCode.Message;   
        }

        [JsonIgnore]public string Prefix {get; protected set;}
        [JsonIgnore]public int Code {get; protected set;}
        [JsonIgnore]public string Message {get; protected set;}

    }
}