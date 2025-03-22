using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.DataProvider
{
    public class JsonDataService
    {
        public string GetJsonData()
        {
           return "{\"name\":\"Ali\"}";
        }
    }
}