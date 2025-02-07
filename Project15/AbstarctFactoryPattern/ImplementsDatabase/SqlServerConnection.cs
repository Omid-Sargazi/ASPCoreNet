using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.DatabaseFactory;

namespace AbstarctFactoryPattern.ImplementsDatabase
{
    public class SqlServerConnection : IDbConnection
    {
        public void Connected()
        {
            Console.WriteLine("Connected to SQL Server.");
        }
    }
}