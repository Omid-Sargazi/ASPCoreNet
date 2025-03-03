using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CachingwithRedis.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;

namespace CachingwithRedis.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController:ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IDistributedCache _cache;
        private readonly ILogger<OrderController> _logger;

        public OrderController(AppDbContext context, IDistributedCache cache, ILogger<OrderController> logger)
        {
            _context = context;
            _cache = cache;
            _logger = logger;
        }

        [HttpGet("nocache/summery")]   
        public async Task<IActionResult> GetOrderSummaryNoCache()
        {
            var stopwatch = Stopwatch.StartNew();

            Thread.Sleep(1500);

            var summery = await _context.Orders
            .GroupBy(o => o.Status)
            .Select(g => new
            {
                Status = g.Key,
                Count = g.Count(),
                TotalAmount =g.Sum(o => o.TotalAmount),
                AverageAmount = g.Average(o => o.TotalAmount)
            }).ToListAsync();


            stopwatch.Stop();
            _logger.LogInformation($"No Cache summary Exceute time:{stopwatch.ElapsedMilliseconds}ms");

            return Ok(new
            {
                Data = summery,
                ExecutionTimeMs = stopwatch.ElapsedMilliseconds,
            });
        }

        [HttpGet("cached/summary")]
        public async Task<IActionResult> GetOrderSummaryCached()
        {
            var stopwatch = Stopwatch.StartNew();
            string cacheKey = "order_summary";
            var cachedSummary = await _cache.GetAsync(cacheKey);

            if(cachedSummary !=null)
            {
                stopwatch.Stop();
                var summaryFromCache = JsonSerializer.Deserialize<object>(cachedSummary);
                _logger.LogInformation($"Cache hit - execution time: {stopwatch.ElapsedMilliseconds}ms");

                return Ok(new
                {
                    Data = summaryFromCache,
                    ExecutionTimeMs = stopwatch.ElapsedMilliseconds,
                    Source = "Cache",
                });

            }

            Thread.Sleep(1500);

            var summary = await _context.Orders
            .GroupBy(o => o.Status)
            .Select(g => new 
            {
                Status = g.Key,
                Count = g.Count(),
                TotalAmount = g.Sum(o => o.TotalAmount),
                AverageAmount = g.Average(o => o.TotalAmount)
            }).ToListAsync();

            var serializedSummary = JsonSerializer.Serialize(summary);

            var cacheOptions = new DistributedCacheEntryOptions
            {
                SlidingExpiration = TimeSpan.FromMinutes(2),
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10)
            };

            await _cache.SetAsync(cacheKey, Encoding.UTF8.GetBytes(serializedSummary),
            cacheOptions);

            stopwatch.Stop();
            _logger.LogInformation($"Cache miss - execution time: {stopwatch.ElapsedMilliseconds}ms");

            return Ok(new 
        { 
            Data = summary,
            ExecutionTimeMs = stopwatch.ElapsedMilliseconds,
            Source = "Database" 
        });
        }

        [HttpGet("clear-cache")]
        public async Task<IActionResult> ClearCache()
        {
            await _cache.RemoveAsync("order_summary");
            return Ok("Cache cleared");
        }
    }
}