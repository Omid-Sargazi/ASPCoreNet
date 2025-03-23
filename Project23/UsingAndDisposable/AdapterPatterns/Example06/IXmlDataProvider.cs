using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example06
{
    public interface IXmlDataProvider
    {
        public string GetXmlData();
    }
}