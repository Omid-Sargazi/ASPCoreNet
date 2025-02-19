using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce.User
{
    public class RegisterUserCommand:IRequest<string>
    {
        public string FullName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}   
    }
}