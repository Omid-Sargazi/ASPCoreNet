using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.DataService
{
    public interface IDataService
    {
        string GetData();
    }
}