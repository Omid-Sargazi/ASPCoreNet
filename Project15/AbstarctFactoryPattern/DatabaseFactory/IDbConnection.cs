using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstarctFactoryPattern.DatabaseFactory
{
    public interface IDbConnection
    {
        void Connected();
    }
}