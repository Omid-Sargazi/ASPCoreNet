using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace APIAuthenticationTest.API.Controllers
{
    public class ApiResult
    {
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

        public override string ToString()
    {
        var contractResolver = new CamelCasePropertyNamesContractResolver();
        return JsonConvert.SerializeObject(this, new JsonSerializerSettings
        {
            ContractResolver = contractResolver
        });
    }
    }
}