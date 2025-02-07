using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.DatabaseFactory;
using AbstarctFactoryPattern.ImplementsDatabase;

namespace AbstarctFactoryPattern.Factory
{
    public class SqlServerFactory : IDbFactory
    {
        public IDbCommand CreateCommand()
        {
            return new SqlServerCommand();
        }

        public IDbConnection CreatedConnection()
        {
            return new SqlServerConnection();
        }
    }
}