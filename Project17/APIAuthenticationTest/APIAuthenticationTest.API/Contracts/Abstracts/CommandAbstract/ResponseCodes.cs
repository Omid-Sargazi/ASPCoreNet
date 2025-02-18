using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract
{
    public static class ResponseCodes
    {
        public static FrameworkResponseMessageCode OperationSuccessful = new CodeAndMessage
        { Code = 1, Message = "Operation successful" };
        public static FrameworkResponseMessageCode OperationFailed = new CodeAndMessage 
        {Code = 2, Message = "Operation failed"};
        public static FrameworkResponseMessageCode OperationCanceled = new CodeAndMessage
        {Code = 3, Message = "Operation was canceled"};
  
    }
}