using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.DatabaseFactory;


namespace AbstarctFactoryPattern
{
    public class DatabaseClient
    {
        private  DatabaseFactory.IDbCommand _dbCommand;
        private DatabaseFactory.IDbConnection _dbConnection;

        public DatabaseClient(IDbFactory factory)
        {
            _dbCommand = factory.CreateCommand();
            _dbConnection = factory.CreatedConnection();
        }

        public void ExecuteQuery(string query)
        {
            _dbCommand.Execute(query);
            _dbConnection.Connected();
        }
    }
}