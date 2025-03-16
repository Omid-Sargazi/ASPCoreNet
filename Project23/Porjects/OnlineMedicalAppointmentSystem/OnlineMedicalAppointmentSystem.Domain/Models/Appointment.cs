using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalAppointmentSystem.Domain.Models
{
    public class Appointment:BaseEntity
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } // Pending, Confirmed, Cancelled
        public string Notes { get; set; }
        public Payment Payment { get; set; }
    }
}