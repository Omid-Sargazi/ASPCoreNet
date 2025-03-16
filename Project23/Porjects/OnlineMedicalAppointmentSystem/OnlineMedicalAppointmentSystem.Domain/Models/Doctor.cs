using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalAppointmentSystem.Domain.Models
{
    public class Doctor:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Appointment> Appointments {get; set;} = new List<Appointment>();
        public List<Schedule> Schedules {get; set;} = new List<Schedule>();
    }
}