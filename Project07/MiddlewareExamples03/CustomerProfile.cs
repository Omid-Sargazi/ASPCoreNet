using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MiddlewareExamples03.Commands;
using MiddlewareExamples03.DTOs;
using MiddlewareExamples03.Models;

namespace MiddlewareExamples03
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            CreateMap<AddCustomerCommand, Customer>();
            CreateMap<Customer, CustomerDto>().ForMember(dest=>dest.FullName, opt=>opt.MapFrom(src=>$"{src.FirstName} {src.LastName}"));
        }
    }
}