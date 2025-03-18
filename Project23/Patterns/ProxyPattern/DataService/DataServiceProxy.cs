using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.DataService
{
    public class DataServiceProxy : IDataService
    {
        private readonly IDataService _dataService;
        private string _chache;
        public DataServiceProxy(IDataService dataService)
        {
            _dataService = dataService;
        }

        public string GetData()
        {
            if(_chache == null){
                _chache = _dataService.GetData();
                 Console.WriteLine("Data fetched from the database and cached.");
            }
            else
            {
                Console.WriteLine("Data fetched from cache.");
            }
            return _chache;
        }
    }
}