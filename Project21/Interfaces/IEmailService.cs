using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEmailService
    {
        void SendOrderConfirmation(string customerEmail, Order order);
    }
}