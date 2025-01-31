using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPattern.ApiServices
{
    public class RealApiService : IApiService
    {
        public string GetData()
        {
            return "Data from the API";
        }
    }
}