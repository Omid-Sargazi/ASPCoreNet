using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using APIIntegrationTest.API.Contracts.Commands;
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

        protected IActionResult OkApiResult(dynamic tResult)
        {
            return Ok(new ApiResult(CommandResponseSuccessful.CreateSuccessful(), tResult));
        }

        protected IActionResult OkApiResult()
        {
            return Ok(new ApiResult(CommandResponseSuccessful.CreateSuccessful()));
        }

        protected IActionResult OkApiCommandResponseResult(CommandResponse tResult)
        {
            return Ok(new ApiResult(tResult));
        }

        protected IActionResult OkApiFileResult(byte[] bytes, string contentType)
        {
            return File(bytes, contentType);
        }


    }
}