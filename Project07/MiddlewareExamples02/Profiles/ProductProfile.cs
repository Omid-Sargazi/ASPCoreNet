using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MiddlewareExamples02.Models;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<AddProductCommand,Product>();
            CreateMap<Product,ProductDto>();
        }
    }
}