using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InetgrationTestInASP.API.Requests
{
    public class AddRequestAgreementCommand
    {
        public int ApplicantRequestId {get; set;}
        public int DocumentId {get; set;}
    }
}