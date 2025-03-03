using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CachingwithRedis.Interfaces
{
    public interface IGreeter
    {
        void Greet(string message);
    }
}