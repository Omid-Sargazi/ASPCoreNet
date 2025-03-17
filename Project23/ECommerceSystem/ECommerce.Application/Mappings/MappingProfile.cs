using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Application.DTOs;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();   
            CreateMap<Order, OrderDto   >().ReverseMap();   
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();   
            CreateMap<Product, ProductDto>().ReverseMap();   
        }   
    }
}