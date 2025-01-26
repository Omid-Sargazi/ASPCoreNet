using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Commands
{
    public class CancelOrderCommand:Command
    {
        public CancelOrderCommand(string orderId)
        {
            OrderId = orderId;
        }
    }
}