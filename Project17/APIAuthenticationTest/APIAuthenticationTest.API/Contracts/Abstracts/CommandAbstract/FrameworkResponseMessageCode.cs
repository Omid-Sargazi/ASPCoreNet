using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract
{
    public sealed class FrameworkResponseMessageCode : ResponseMessageCode
    {
        public FrameworkResponseMessageCode(CodeAndMessage codeAndMessage):base("FrameworkException",codeAndMessage.Code,codeAndMessage.Message)
        {
            
        }   

        public static implicit operator FrameworkResponseMessageCode(CodeAndMessage codeAndMessage)
        {
            return new FrameworkResponseMessageCode(codeAndMessage);
        }
    }
}