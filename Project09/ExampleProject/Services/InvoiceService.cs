using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleProject.Entities;
using ExampleProject.Repositories;

namespace ExampleProject.Services
{
    public class InvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IOrderRepository _orderRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository, IOrderRepository orderRepository)
        {
            _invoiceRepository = invoiceRepository;
            _orderRepository = orderRepository;
        }

        public Invoice GenerateInvoice(Guid orderId)
        {
            var order = _orderRepository.GetById(orderId);
            if (order == null)
                throw new Exception("Order not found.");

            var totalAmount = order.CalculateTotalAmount();
            var invoice = new Invoice(orderId, totalAmount);

            _invoiceRepository.Save(invoice);
            return invoice;
        }
    }
}