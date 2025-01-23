using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Tests.Payment
{
    public class OrderService
    {
        private readonly IPaymentService _paymentService;
        private readonly IInventoryService _inventoryService;

        public OrderService(IPaymentService paymentService, IInventoryService inventoryService)
        {
            _paymentService = paymentService;
            _inventoryService = inventoryService;
        }

        public bool PlaceOrder(int itemId, int quantity, decimal amount)
        {
            if (!_inventoryService.IsItemAvailable(itemId, quantity))
            return false;

            if (!_paymentService.ProcessPayment(amount))
            return false;

             _inventoryService.ReserveItem(itemId, quantity);
             return true;
        }
    }
}