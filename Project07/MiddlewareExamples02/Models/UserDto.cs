using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples02.Models
{
    public record UserDto(Guid Id, string Name, string Email);
}