using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Integration.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController:ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[] {"value1", "value2"});
        }
    }
}