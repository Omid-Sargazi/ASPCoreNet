using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalAppointmentSystem.Domain.Models
{
    public class Patient
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string MedicalHistory {get; set;}
        public List<Appointment> Appointments {get; set;} = new List<Appointment>();
    }
}