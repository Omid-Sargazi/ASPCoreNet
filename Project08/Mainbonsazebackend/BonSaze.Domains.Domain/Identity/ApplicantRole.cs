using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BonSaze.Domains.Domain.Identity
{
    public class ApplicantRole:IdentityUser<Guid>
    {
         public string Description { get; set; }
    }
}