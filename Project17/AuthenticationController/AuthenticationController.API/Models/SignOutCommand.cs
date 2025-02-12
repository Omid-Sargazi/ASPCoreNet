using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AuthenticationController.API.Models
{
    public class SignOutCommand:Command
    {
        public ClaimsPrincipal User {get; set;}
    }
}