using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LoggigMonitoringMatter.Controllers
{
    [ApiController]
    [Route("api/secure")]
    public class SecureController:ControllerBase
    {
        [Authorize]
        [HttpGet("data")]
        public IActionResult GetSecureData()
        {
            return Ok(new {Message="This is protected data"});
        }

        [Authorize(Roles ="admin")]
        [HttpGet("admin")]
        public IActionResult GetAdminData()
        {
            return Ok(new { Message = "Admin-only data!" });
        }
    }
}