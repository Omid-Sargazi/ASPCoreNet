using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMedicalAppointmentSystem.Domain.Exceptions;
using OnlineMedicalAppointmentSystem.Domain.Models;
using OnlineMedicalAppointmentSystem.Infrastructure.Repositories;

namespace OnlineMedicalAppointmentSystem.Application.Commands
{
    public class BookAppointmentCommandHandler : ICommandHandler<BookAppointmentCommand>
    {
        private readonly IRepository<Appointment> _appointmenteRepo;
        private readonly IRepository<Schedule> _scheduleRepo;
        public BookAppointmentCommandHandler(IRepository<Appointment> appointmenteRepo, IRepository<Schedule> scheduleRepo)
        {
            _appointmenteRepo = appointmenteRepo;
            _scheduleRepo = scheduleRepo;
        } 
        public async Task Handle(BookAppointmentCommand command)
        {
            var schedule = (await _scheduleRepo.GetAllAsync())
            .FirstOrDefault(s => s.DoctorId == command.DoctorId && s.StartTime <= command.AppointmentDate && s.EndTime >= command.AppointmentDate);

            if(schedule == null || schedule.IsBooked)
                throw new DoctorNotAvailableException("Doctor is unavailable at the requested time.");
            
            var appointment = new Appointment
            {
                PatientId = command.PatientId,
                DoctorId = command.DoctorId,
                AppointmentDate = command.AppointmentDate,
                Status = "Pending",
                Notes = command.Notes,
            };

            schedule.IsBooked = true;
            await _scheduleRepo.UpdateAsync(schedule);
            await _appointmenteRepo.AddAsync(appointment);

        }
    }
}