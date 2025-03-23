using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example06
{
    public class JsonDataService
    {
        public string GetJsonData()
        {
            return "{ \"Name\": \"John\", \"Age\": 30 }";
        }
    }
}