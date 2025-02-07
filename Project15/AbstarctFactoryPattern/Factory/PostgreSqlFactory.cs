using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.DatabaseFactory;
using AbstarctFactoryPattern.ImplementsDatabase;

namespace AbstarctFactoryPattern.Factory
{
    public class PostgreSqlFactory : IDbFactory
    {
        public IDbCommand CreateCommand()
        {
            return new PostgreSqlCommand();
        }

        public IDbConnection CreatedConnection()
        {
            return new PostgreSqlConnection();
        }
    }
}