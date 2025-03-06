using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.MethodEnjection
{
    public class Order
    {
        public string OrderId { get; private set; }
        public List<OrderItem> Items { get; private set; }
        public decimal TotalAmount => Items.Sum(item => item.Total);
        public bool IsProcessed { get; private set; }


         public Order(string orderId)
        {
            OrderId = orderId;
            Items = new List<OrderItem>();
            IsProcessed = false;
        }
        
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        
        // Regular method, no injection needed
        public decimal CalculateTotal()
        {
            return TotalAmount;
        }

        public bool ProcessOrder(ILogger logger)
        {
            try
            {
                if(Items.Count ==0)
            {
                logger.LogError($"Cannot process order {OrderId}: No items in order");
                return false;
            }
            foreach(var item in Items)
            {
                logger.Log($"Processing item: {item.Name} x{item.Quantity}");
            }
             IsProcessed = true;
            logger.Log($"Order {OrderId} processed successfully. Total: ${TotalAmount}");
            return true;
            }
            catch (Exception ex)
            {
                
                logger.LogError($"Error processing order {OrderId}: {ex.Message}");
                 return false;
            }
        }
    }
}