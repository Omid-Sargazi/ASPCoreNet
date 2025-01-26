using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Commands
{
    public class ModifyOrderCommand:Command
    {
        public List<string> NewItem { get; set; }

        public ModifyOrderCommand(string orderId, List<string> newItems)
        {
            NewItem = newItems;
            OrderId = orderId;
        }
    }
}