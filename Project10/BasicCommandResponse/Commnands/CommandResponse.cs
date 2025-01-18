using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCommandResponse.Commnands
{
    public class CommandResponse
    {
        public string Prefix {get; set;}
        public int Code {get; set;}
        public string Message {get; set;}

        public CommandResponse(string prefix, int code, string message)
        {
            Prefix = prefix;
            Code = code;
            Message = message;

        }
    }
}