using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SOLIDPrinciples.Controllers
{
    public class BaseController:Controller
    {
        protected readonly ILogger<BaseController> _logger;

        public BaseController(ILogger<BaseController> logger)
        {
            _logger = logger;
        }

        public IActionResult HandleError(Exception ex)
        {
            _logger.LogError(ex, "An error occured");
            return View("Error");
        }
    }
}