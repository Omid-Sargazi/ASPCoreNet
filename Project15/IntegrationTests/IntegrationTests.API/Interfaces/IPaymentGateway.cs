using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationTests.API.Interfaces
{
    public interface IPaymentGateway
    {
        Task<bool> ProcessPaymentAsync(decimal amount);
    }
}