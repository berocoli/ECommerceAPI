using System;
using Domain;
using AutoMapper;
using Application.DTOs;

namespace Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductsCategory, ProductsCategoryDto>().ReverseMap();

        }
    }
}

