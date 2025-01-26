using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Responses
{
    public abstract class CommandResponse
    {
        public CommandResponse()
        {
            Status = "Pending";
        }

        public CommandResponse(string orderId, string status)
        {
            Status = status;
            OrderId = orderId;
        }

        public string OrderId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}