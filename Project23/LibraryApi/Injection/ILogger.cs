using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Injection
{
    public interface ILogger
    {
        void log(string message);
    }
}