using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrivenDesign.ValueObjets;

namespace DrivenDesign.Aggregations
{
    public class Order
    {
        public int Id { get; private set; }
    public Address ShippingAddress { get; private set; }
    public List<OrderItem> OrderItems { get; private set; }

    public Order(int id, Address shippingAddress)
    {
        Id = id;
        ShippingAddress = shippingAddress;
        OrderItems = new List<OrderItem>();
    }

    public void AddOrderItem(OrderItem orderItem)
    {
        OrderItems.Add(orderItem);
    }
    }



    public class OrderItem
{
    public int Id { get; private set; }
    public string ProductName { get; private set; }
    public decimal Price { get; private set; }

    public OrderItem(int id, string productName, decimal price)
    {
        Id = id;
        ProductName = productName;
        Price = price;
    }
}
}