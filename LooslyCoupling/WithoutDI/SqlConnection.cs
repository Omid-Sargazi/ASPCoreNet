using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.WithoutDI
{
    public sealed class SqlConnection
    {
        private readonly string _connection;
        public SqlConnection(string sqlConnection)
        {
            _connection = sqlConnection;
        }
    }
}