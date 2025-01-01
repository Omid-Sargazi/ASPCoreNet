using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiddlewareExample02.Repositories;

namespace MiddlewareExample02.Configurations
{
    public class ApiKeyValidator : IApiKeyValidator
    {
        public bool IsValid(string apiKey)
        {
            return apiKey == "my-secret-api-key";
        }
    }
}