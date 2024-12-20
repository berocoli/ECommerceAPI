using Domain;
using AutoMapper;
using Application.DTOs;
using Domain.Entities.BaseEntity;
using Application.DTOs.Product.Details;

namespace Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Existing mappings
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, CreateAdminDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, UpdateOrderDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, RandomizedProductDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ReverseMap();

            // Product to ProductDto mapping
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));

            CreateMap<ProductDto, CategoryDto>().ReverseMap();
            CreateMap<ProductsCategory, ProductsCategoryDto>().ReverseMap();
            CreateMap<ProductDetail, ProductDetailDto>()
                .ForMember(dest => dest.ProductId, opt => opt.Ignore())
                .ReverseMap();

            // Cart mappings
            CreateMap<Cart, GetCartDto>()
                .ForMember(dest => dest.CartProducts, opt => opt.MapFrom(src => src.CartItems));
            CreateMap<CartItem, CartProductDto>()
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product))
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity));

            CreateMap<Cart, CreateCartDto>().ReverseMap();
            CreateMap<Cart, OrderCartDto>().ReverseMap();

            // Category to CategoryDto mapping
            CreateMap<ProductsCategory, CategoryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.CategoryProducts, opt => opt.MapFrom(src => src.Products))
                .ReverseMap();

            // Product to CategoryProduct mapping
            CreateMap<Product, CategoryProduct>()
                .ForMember(dest => dest.product, opt => opt.MapFrom(src => src));

            // *** New Mappings for GetByCategoryDto and ProductDtoForGetCategories ***

            // Map ProductsCategory to GetByCategoryDto
            CreateMap<ProductsCategory, GetByCategoryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));

            // Map Product to ProductDtoForGetCategories
            CreateMap<Product, ProductDtoForGetCategories>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl));
        }
    }
}
