using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using CachingwithRedis.Data;
using CachingwithRedis.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace CachingwithRedis.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController:ControllerBase
    {
        // private readonly IMemoryCache _cache;
        private readonly AppDbContext _context;
        private readonly ILogger<ProductController> _logger;
        private readonly IDistributedCache _cache;
        public ProductController(IDistributedCache cache, AppDbContext context, ILogger<ProductController> logger)
        {
            _cache = cache;
            _context = context;
            _logger = logger;
        }
        

        [HttpGet("nocache")]
        public async Task<IActionResult> GetProductsNoCache()
        {
            var stopWatch = Stopwatch.StartNew();

            Thread.Sleep(2000);

            var products = await _context.Products.ToListAsync();
            stopWatch.Stop();
            _logger.LogInformation($"No Cache Exceute time:{stopWatch.ElapsedMilliseconds}ms");

            return Ok(new 
            {
                Data = products,
                ExecutionTimeMs = stopWatch.ElapsedMilliseconds
            });
        }

        [HttpGet("cached")]
        public async Task<IActionResult> GetProductsCached()
        {
            var stopwatch = Stopwatch.StartNew();
            string cacheKey = "all_products"; 
            var cachedProducts = await _cache.GetAsync(cacheKey);

            if(cachedProducts != null)
            {
                stopwatch.Stop();
                var productsFromCache = JsonSerializer.Deserialize<List<Product>>(cachedProducts);
                _logger.LogInformation($"Cache hit - execution time: {stopwatch.ElapsedMilliseconds}ms");

                return Ok( new
                {
                    Data = productsFromCache,
                    ExecutionTimeMs = stopwatch.ElapsedMilliseconds,
                    Source = "Cache",
                }
                    
                );

            }
            Thread.Sleep(2000);
            var products = await _context.Products.ToListAsync();
            var serializedProducts = JsonSerializer.Serialize(products);

            var cacheOptions = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            };

            await _cache.SetAsync(cacheKey, Encoding.UTF8.GetBytes(serializedProducts),cacheOptions);
            stopwatch.Stop();
            _logger.LogInformation($"Cache miss - execution time: {stopwatch.ElapsedMilliseconds}ms");

            return Ok
            (new{
                Data = products,
                ExecutionTimeMs = stopwatch.ElapsedMilliseconds,
                Source = "Database"
            });
        }
    }
}