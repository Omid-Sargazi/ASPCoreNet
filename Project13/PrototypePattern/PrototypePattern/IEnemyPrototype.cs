using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern.PrototypePattern
{
    public interface IEnemyPrototype
    {
        IEnemyPrototype Clone();
    }
}
