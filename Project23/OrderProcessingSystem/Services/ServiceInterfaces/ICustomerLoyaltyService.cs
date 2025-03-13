using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Services.ServiceInterfaces
{
    public interface ICustomerLoyaltyService
    {
        Task AddPointsForPurchaseAsync(int customerId, decimal amount);
    }
}