using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example02
{
    public class ExternalDateService
    {
        public string GetDate() => "03/22/2025";
    }
}