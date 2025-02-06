using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqExample.Interfaces
{
    public interface IApiClient
    {
        public Task<string> GetDataAsunc();
    }
}