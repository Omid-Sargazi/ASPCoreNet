using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.DataService
{
    public class DataService : IDataService
    {
        public string GetData()
        {
            return "data from data base";
        }
    }
}