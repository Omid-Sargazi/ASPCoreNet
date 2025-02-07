using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.DatabaseFactory;

namespace AbstarctFactoryPattern.ImplementsDatabase
{
    public class PostgreSqlCommand : IDbCommand
    {
        public void Execute(string query)
        {
            Console.WriteLine($"Executing PostgreSQL command: {query}");
        }
    }
}