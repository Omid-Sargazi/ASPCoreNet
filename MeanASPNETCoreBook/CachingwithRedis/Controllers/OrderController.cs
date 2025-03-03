using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
    }
}