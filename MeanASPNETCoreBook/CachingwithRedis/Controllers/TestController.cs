using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace CachingwithRedis.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController:ControllerBase
    {
        [HttpGet("public")]
        public IActionResult PublicEndpoint()
        {
            return Ok("This endpoint has global rate limiting.");
        }

        [EnableRateLimiting("custom-limit")]
        [HttpGet("limited")]
        public IActionResult LimitedEndpoint()
        {
            return Ok("This endpoint allows only 3 requests per 15 seconds.");
        }

        [EnableRateLimiting("sliding")]
        [HttpGet("sliding")]
        public IActionResult SlidingLimitEndpoint()
        {
            return Ok("This endpoint uses sliding window rate limiting.");
        }
    }
}