using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public interface IPrototype<T>
    {
        T CLone();
    }
}