using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExample02.Repositories
{
    public interface IApiKeyValidator
    {
        bool IsValid(string apiKey);
    }
}