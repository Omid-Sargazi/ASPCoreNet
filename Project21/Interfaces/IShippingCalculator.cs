using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IShippingCalculator
    {
        decimal CalculateShipping(List<OrderItem> items, string shippingAddress);
    }
}