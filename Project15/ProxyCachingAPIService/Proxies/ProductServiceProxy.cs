using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProxyCachingAPIService.Interfaces;
using ProxyCachingAPIService.Services;

namespace ProxyCachingAPIService.Proxies
{
    public class ProductServiceProxy : IProductService
    {
        protected readonly IProductService _realService;
        private List<string>? _cachedProducts;
        private DateTime _cacheTime;

        public ProductServiceProxy(IProductService realService)
        {
            _realService = realService;
        }
        public async Task<List<string>> GetProductsAsync()
        {
            if(_cachedProducts != null && (DateTime.Now - _cacheTime).TotalMinutes <5)
            {
                Console.WriteLine("Returning cached data...");
                return _cachedProducts;
            }
            Console.WriteLine("Cache expired. Fetching fresh data...");
            _cachedProducts = await _realService.GetProductsAsync();
            return _cachedProducts;
        }
    }
}