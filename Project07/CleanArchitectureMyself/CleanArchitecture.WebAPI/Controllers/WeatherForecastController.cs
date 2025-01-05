using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.WeatherForecasts.Queries;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController:ControllerBase
    {
        private readonly IWeatherForecastService _service;
        private readonly IValidator<WeatherForecastDto> _validator;

        public WeatherForecastController(IWeatherForecastService service, IValidator<WeatherForecastDto> validator)
        {
            _service = service;
            _validator = validator;
        }

       /* [HttpGet]
        public IEnumerable<WeatherForecastDto> Get()
        {
            return _service.GetWeatherForecasts();
        }*/

        [HttpGet]
        public IActionResult Get()
        {
            var forecasts = _service.GetWeatherForecasts();

            foreach(var forecast in forecasts)
            {
                var validationResult = _validator.Validate(forecast);
                if(!validationResult.IsValid)
                {
                    return BadRequest(validationResult.Errors);
                }
            }
            return Ok(forecasts);
        }
    }
}