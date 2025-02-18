using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIntegrationTest.API.Contracts.Commands;

namespace APIIntegrationTest.API.Controllers
{
    public class ApiResult
    {
        public ApiResult()
        {
            
        }

        public ApiResult(CommandResponse commandResponse, dynamic result = null, bool hasError = false)
        {
            HasError = hasError;
            Code = commandResponse.Code;
            Message = commandResponse.Message;
            Result = result;   
        }

        public bool HasError {get; set;}
        public dynamic Message {get; set;}
        public int? Code {get; set;}
        public dynamic Result {get; set;}


       
        
    }
}