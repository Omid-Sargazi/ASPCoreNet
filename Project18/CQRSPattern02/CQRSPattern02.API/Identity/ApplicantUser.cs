using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CQRSPattern02.API.Identity
{
    public class ApplicantUser:IdentityUser
    {
        public string FirstName {get;set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
        public bool IsActive {get; set;} = true;   
    }
}