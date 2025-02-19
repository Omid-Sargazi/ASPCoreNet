using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce.Features.Orders.Commands
{
    public class PlaceOrderCommand:IRequest<Guid>
    {
        public string CustomerName {get; set;}
        public string ProductName {get; set;}   
        public int Quantity {get; set;}
        public decimal TotalPrice {get; set;}
    }
}