using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAuthenticationTest.API.Contracts.Abstracts
{
    public abstract class ResponseMessageCode
    {
        protected ResponseMessageCode(string prefix, int code, string message)
        {
            Prefix = prefix;
            Code = code;
            Message = message;   
        }

        public string Prefix {get;}
        public int Code {get;}
        public string Message {get;}   
    }
}