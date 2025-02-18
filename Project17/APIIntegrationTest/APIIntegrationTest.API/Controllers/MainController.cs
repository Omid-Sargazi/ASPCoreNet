using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIntegrationTest.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIIntegrationTest.API.Controllers
{
    [ApiController]
    [Route("api/v{version.apiVersion}/[controller]")]
    public class MainController:ControllerBase
    {
        protected readonly IDistributor _distributor;

        public MainController(IDistributor distributor)
        {
            _distributor = distributor;
        }
    }
}