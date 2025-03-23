using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example03
{
    public class OldDatabase
    {
        public string FetchData()
        {
            return "id:1,name:علی";
        }
    }
}