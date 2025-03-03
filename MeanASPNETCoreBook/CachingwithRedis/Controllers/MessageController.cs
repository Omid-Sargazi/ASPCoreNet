using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace CachingwithRedis.Controllers
{
    [ApiController]
    [Route("api/message")]
    public class MessageController:ControllerBase
    {
        private readonly IDistributedCache _cache;

        public MessageController(IDistributedCache cache)
        {
            _cache = cache;
        }

        [HttpGet("cache")]
        public async Task<IActionResult> GetMessage()
        {
            string cacheKey = "daily_message";
            var cacheMessage = await _cache.GetStringAsync(cacheKey);

            if(cacheMessage !=null)
            {
                return Ok(new
                
                {
                    Message = cacheMessage,
                    Source = "Cache",
                    Timestamp = DateTime.Now
                });

            }
                string newMesssage = $"Hello! This is the message for {DateTime.Now.ToShortDateString}";

                Thread.Sleep(1000);

                var cacheOptions = new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
                };

                await _cache.SetStringAsync(cacheKey, newMesssage, cacheOptions);

                return Ok(new {
                    Message = newMesssage,
                    Source = "Generated",
                    Timestamp = DateTime.Now
                });
        }
    }
}