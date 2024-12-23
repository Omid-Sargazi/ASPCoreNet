using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Exceptions
{
    public class OrderNotFoundException:Exception
    {
        public OrderNotFoundException(Guid orderId):base($"order with ID {orderId} was not found.")
        {

        }
    }
}