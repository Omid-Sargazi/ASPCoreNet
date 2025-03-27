using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP.DataAndReport
{
    public class DataSource : IDataSource
    {
        public IEnumerable<object> GetData()
        {
            return new List<Object> 
            {
                new { Id = 1, Name = "Product A" },
                new { Id = 2, Name = "Product B" }
            };
        }
    }
}