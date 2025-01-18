using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;

namespace BasicCommandResponse.PlaceOrder
{
    public class CancelOrderCommand:Command
    {
        public string OrderId {get; set;}
        public string Reason {get; set;}

        public CancelOrderCommand(string orderId, string reason)
        {
            OrderId = orderId;
            Reason = reason;
        }
    }
}