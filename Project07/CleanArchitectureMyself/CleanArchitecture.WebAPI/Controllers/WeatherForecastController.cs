using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.WeatherForecasts.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController
    {
        private readonly IWeatherForecastService _service;

        public WeatherForecastController(IWeatherForecastService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<WeatherForecastDto> Get()
        {
            return _service.GetWeatherForecasts();
        }
    }
}