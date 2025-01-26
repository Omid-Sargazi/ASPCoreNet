using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Responses
{
    public class CommandResponseCanceled:CommandResponse
    {
        public CommandResponseCanceled(string orderId, string message="Operation Canceled")
        {
            OrderId = orderId;
            Status = "Canceled";
            Message = message;
        }

        public static CommandResponse CreateCaceled(string orderId, string message="Operation Canceled")
        {
            return new CommandResponseCanceled(orderId,message);
        }
    }
}