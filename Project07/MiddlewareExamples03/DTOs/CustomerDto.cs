using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples03.DTOs
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
         public string FullName { get; set; }
         public string Email { get; set; }
    }
}