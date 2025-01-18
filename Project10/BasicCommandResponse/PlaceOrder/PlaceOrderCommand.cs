using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;

namespace BasicCommandResponse.PlaceOrder
{
    public class PlaceOrderCommand:Command
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string CustomerId { get; set; }

       public PlaceOrderCommand(string productName, int quantity, string customerId)
    {
        ProductName = productName;
        Quantity = quantity;
        CustomerId = customerId;
    }
    }
}