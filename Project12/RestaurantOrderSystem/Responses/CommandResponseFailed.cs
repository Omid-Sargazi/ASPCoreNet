using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Responses
{
    public class CommandResponseFailed:CommandResponse
    {
        public CommandResponseFailed(string orderId, string message="Operation Failed")
        {
            OrderId = orderId;
            Status = "Failed";
            Message = message;
        }

        public static CommandResponse CreateFailed(string orderId, string message="Operation Failed")
        {
            return new CommandResponseFailed(orderId, message);
        }
    }
}