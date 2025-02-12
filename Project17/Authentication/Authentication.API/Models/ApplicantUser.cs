using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Authentication.API.Models
{
    public class ApplicantUser:IdentityUser<Guid>
    {
        public bool IsSuperAdmin { get; set; }
        public string? BusinessCode { get; set; }
        public string? NationalCode { get; set; }
        public string? CompanyNationalCode { get; set; }
        public string? ApplicantUnitName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyRole { get; set; }
        public string? MobileNumber { get; set; }
        public bool IsAgent { get; set; }
        public string? AgentNationalCode { get; set; }
        public bool IsDeleted { get; protected set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public void SetDelete()
        {
            IsDeleted = true;
        }
    }
}