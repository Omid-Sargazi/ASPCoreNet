using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAuthenticationTest.API.Contracts.Abstracts
{
    public abstract class ResponseMessageCode
    {
        protected ResponseMessageCode()
        {
            
        }

        public string Prefix {get;}
        public int Code {get;}
        public string Message {get;}   
    }
}