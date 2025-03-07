using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace Implements
{
    public class OrderProcessor
    {
        private readonly IBookInventory _inventory;
        private readonly IShippingCalculator _emailService;

        private readonly IEmailService _shippingCalculator;

        public OrderProcessor(IBookInventory bookInventory, IShippingCalculator shippingCalculator,IEmailService emailService)
        {
            _emailService = emailService;
            _inventory = bookInventory;
            _shippingCalculator = shippingCalculator;
        } 

        
    }
}