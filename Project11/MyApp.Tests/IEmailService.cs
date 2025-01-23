using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Tests
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(string email);
    }
}