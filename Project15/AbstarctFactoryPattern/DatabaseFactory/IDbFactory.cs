using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstarctFactoryPattern.DatabaseFactory
{
    public interface IDbFactory
    {
        public IDbCommand CreateCommand();
        public IDbConnection CreatedConnection();
    }
}