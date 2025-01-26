using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Commands
{
    public abstract class Command
    {
        public string OrderId { get; set; }
    }
}