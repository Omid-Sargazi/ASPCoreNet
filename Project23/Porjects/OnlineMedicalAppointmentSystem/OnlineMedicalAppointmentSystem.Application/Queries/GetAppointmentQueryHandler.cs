using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OnlineMedicalAppointmentSystem.Application.DTOs;
using OnlineMedicalAppointmentSystem.Domain.Models;
using OnlineMedicalAppointmentSystem.Infrastructure.Repositories;

namespace OnlineMedicalAppointmentSystem.Application.Queries
{
    public class GetAppointmentQueryHandler : IQueryHandler<GetAppointmentQuery, AppointmentDto>
    {
        private readonly IRepository<Appointment> _appointmentRepo;
        private readonly IMapper _mapper;

        public GetAppointmentQueryHandler(IRepository<Appointment> repository, IMapper mapper)
        {
            _appointmentRepo = repository;
            _mapper = mapper;
            
        }
        public async Task<AppointmentDto> Handle(GetAppointmentQuery query)
        {
            var appointment = await _appointmentRepo.GetByIdAsync(query.AppointmentId);
            return _mapper.Map<AppointmentDto>(appointment);
        }
    }
}