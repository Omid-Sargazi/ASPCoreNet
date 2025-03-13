using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingSystem.Interfacses;
using OrderProcessingSystem.Services.ServiceInterfaces;

namespace OrderProcessingSystem.Services.ServiceImplementations
{
    public class OrderValidator : IOrderValidator
    {
        private readonly IProductRepository _productRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly ILogger _logger;

        public OrderValidator(IProductRepository productRepository, ICustomerRepository customerRepository, ILogger logger)
        {
            _customerRepository = customerRepository;
            _logger = logger;
            _productRepository = productRepository;
        }
        public async Task<ValidationResult> ValidateOrderAsync(OrderRequest orderRequest)
        {
            _logger.LogInformation($"VAlidating order for customer {orderRequest.CustomerId}");
            var customer = await _customerRepository.GetByIdAsync(orderRequest.CustomerId);
            if(customer == null)
                return new ValidationResult{IsValid = false, ErrorMessage = "Customer not found"};

            if(orderRequest.Items==null || !orderRequest.Items.Any())
                return new ValidationResult{IsValid = false, ErrorMessage ="Order must contain at least one item"};

            var productIds = orderRequest.Items.Select(i => i.ProductId).ToList();
            var products = await _productRepository.GetByIdsAsync(productIds);
            if(products.Count != productIds.Count)
            {
                return new ValidationResult{IsValid = false, ErrorMessage = "One or more products not found"};
            }

            foreach (var item in orderRequest.Items)
        {
            var product = products.First(p => p.Id == item.ProductId);
            if (!product.IsActive)
            {
                return new ValidationResult { IsValid = false, ErrorMessage = $"Product {product.Name} is not available" };
            }
            if (product.StockQuantity < item.Quantity)
            {
                return new ValidationResult { IsValid = false, ErrorMessage = $"Insufficient stock for product {product.Name}" };
            }
        }

        return new ValidationResult { IsValid = true };
        }
    }
}