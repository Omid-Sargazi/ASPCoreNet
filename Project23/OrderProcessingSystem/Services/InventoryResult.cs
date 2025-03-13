using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Services
{
    public class InventoryResult
    {
        public bool Success { get; set; }
        public List<int> OutOfStockProductIds { get; set; } = new List<int>();
    }
}