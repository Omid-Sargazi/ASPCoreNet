using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using AutoMapper;
using BookstoreManagement.Application.DTOs;
using BookstoreManagement.Domain.Entities;

namespace BookstoreManagement.Application.Profiles
{
    public class InventoryProfile:Profile
    {
        public InventoryProfile()
        {
            CreateMap<Inventory,InventoryDto>()
            .ForMember(dest =>dest.BookTitle, opt=>opt.MapFrom(src=>src.Book.Title))
            .ForMember(dest=>dest.Quantity, opt=>opt.MapFrom(src=>src.Quantity));
        }
    }
}