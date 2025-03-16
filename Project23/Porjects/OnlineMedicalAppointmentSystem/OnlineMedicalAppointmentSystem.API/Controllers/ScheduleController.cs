using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicalAppointmentSystem.Domain.Models;
using OnlineMedicalAppointmentSystem.Infrastructure.Repositories;

namespace OnlineMedicalAppointmentSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleController:ControllerBase
    {
        private readonly IRepository<Schedule> _scheduleRepo;

        public ScheduleController(IRepository<Schedule> repository)
        {
            _scheduleRepo = repository;
        }

        [HttpGet("{doctorId}")]
        public async Task<IActionResult> GetDoctorSchedule( int doctorId)
        {
            var schedules = (await _scheduleRepo.GetAllAsync()).Where(s => s.DoctorId == doctorId);
            return Ok(schedules);
        }
    }
}