using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Profile
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<AddProductCommand,Product>();
        }
    }
}