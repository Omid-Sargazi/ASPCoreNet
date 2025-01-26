using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Commands
{
    public class PlaceOrderCommand:Command
    {
        public List<string> Itesm { get; set; }

        public PlaceOrderCommand(List<string> items)
        {
            OrderId = Guid.NewGuid().ToString();
            Itesm = items;
        }
    }
}