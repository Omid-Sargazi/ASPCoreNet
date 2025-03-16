using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicalAppointmentSystem.Application.Commands;
using OnlineMedicalAppointmentSystem.Application.DTOs;
using OnlineMedicalAppointmentSystem.Application.Queries;

namespace OnlineMedicalAppointmentSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController:ControllerBase
    {
        private readonly ICommandHandler<BookAppointmentCommand> _bookCommandHandler;
        private readonly IQueryHandler<GetAppointmentQuery, AppointmentDto> _getQueryHandler;
        private readonly IMapper _mapper;

        public AppointmentController(
            ICommandHandler<BookAppointmentCommand> bookCommandHandler,
            IQueryHandler<GetAppointmentQuery, AppointmentDto> getQueryHandler,
            IMapper mapper)
        {
            _bookCommandHandler = bookCommandHandler;
            _getQueryHandler = getQueryHandler;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppointment(int id)
        {
            var query = new GetAppointmentQuery {AppointmentId = id};
            var result = await _getQueryHandler.Handle(query);
            return Ok(result);
        }

    }
}