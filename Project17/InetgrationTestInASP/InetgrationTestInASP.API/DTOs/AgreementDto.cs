using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InetgrationTestInASP.API.DTOs
{
    public class AgreementDto
    {
       public int ApplicantRequestId { get; set; }
        public int DocumentId { get; set; }
        public int AgreementVersion { get; set; } 
    }
}