using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookstoreManagement.Application.DTOs;
using BookstoreManagement.Domain.Entities;

namespace BookstoreManagement.Application.Profiles
{
    public class BookProfile:Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDto>()
            .ForMember(dest => dest.AuthorName, opt=>opt.MapFrom(src=>src.Author.Name))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src =>src.Category.Name))
            .ForMember(dest => dest.InventoryQuantity, opt => opt.MapFrom(src => src.Inventory.Quantity));
            
            CreateMap<BookDto, Book>();
        }     
    }
}