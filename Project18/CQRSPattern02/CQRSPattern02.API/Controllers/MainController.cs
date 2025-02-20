using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern02.API.Contracts.Markers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern02.API.Controllers
{
    public class MainController:ControllerBase
    {
        private readonly IDistributor _distributor;

        public MainController(IDistributor distributor)
        {
            _distributor = distributor;   
        }

        protected IActionResult OkApiResult<T>(T result)
        {
            return Ok( new ApiResponse<T>
                {
                    Success = true,
                    Data = result,
                    TTimestamp = DateTime.UtcNow,
                }
            );
        }

    }


    public class ApiResponse<T>
    {
        public bool Success {get; set;}
        public T Data {get; set;}
        public DateTime TTimestamp {get; set;}
    }
}