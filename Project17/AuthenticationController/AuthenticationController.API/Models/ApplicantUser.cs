using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationController.API.Models
{
    public class ApplicantUser:IdentityUser<Guid>
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public bool IsDeleted {get; protected set;}

        public void SetDelete() => IsDeleted = true;
    }
}