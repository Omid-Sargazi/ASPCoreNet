using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Responses
{
    public class CommandResponseSuccessful:CommandResponse
    {
        public CommandResponseSuccessful(string orderId, string message="Operation Successful")
        {
            OrderId = orderId;
            Status = "Success";
            Message = message;
        }


    }
}