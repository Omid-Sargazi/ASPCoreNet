using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProxyCachingAPIService.Interfaces;

namespace ProxyCachingAPIService.Services
{
    public class ProductService : IProductService
    {

        public async Task<List<string>> GetProductsAsync()
        {
            Console.WriteLine("Fetching data from the database...");
            await Task.Delay(2000);
            return new List<string> {"Laptop", "smartphone","Tablet"};
        }
    }
}