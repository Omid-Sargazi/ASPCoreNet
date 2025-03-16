using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalAppointmentSystem.Domain.Models
{
    public class Payment:BaseEntity
    {
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; } // Pending, Paid, Failed
        public DateTime TransactionDate { get; set; }
    }
}