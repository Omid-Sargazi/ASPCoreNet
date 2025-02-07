using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.DatabaseFactory;

namespace AbstarctFactoryPattern.ImplementsDatabase
{
    public class SqlServerCommand : IDbCommand
    {
        public void Execute(string query)
        {
            Console.WriteLine($"Executing SQL Server command: {query}");
        }
    }
}