using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalAppointmentSystem.Domain.Exceptions
{
    public class DoctorNotAvailableException:Exception
    {
        public DoctorNotAvailableException(string message):base(message){}
    }
}