using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern.NewPrototypePattern
{
    public interface IEnemyPrototypes
    {
        IEnemyPrototypes Clone();
    }
}