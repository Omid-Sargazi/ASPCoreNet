using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Services.ServiceInterfaces
{
    public interface IOrderValidator
    {
        Task<ValidationResult> ValidateOrderAsync(OrderRequest orderRequest);
    }
}