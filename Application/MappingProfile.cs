using Domain;
using AutoMapper;
using Application.DTOs;

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

            // Ensure Product to ProductDto mapping exists
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl));

            CreateMap<ProductsCategory, ProductsCategoryDto>().ReverseMap();

            // Update the Cart to GetCartDto mapping
            CreateMap<Cart, GetCartDto>()
                .ForMember(dest => dest.CartProducts, opt => opt.MapFrom(src => src.CartItems));

            // Ensure CartItem maps to CartProductDto correctly
            CreateMap<CartItem, CartProductDto>()
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product))
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity));

            CreateMap<Cart, CreateCartDto>().ReverseMap();
            CreateMap<Cart, OrderCartDto>().ReverseMap();

            // Remove or adjust this mapping if it's not correct
            // CreateMap<ProductsCategory, CategoryDto>().ReverseMap();

            // Add the mapping between Category and CategoryDto
            CreateMap<ProductsCategory, CategoryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.CategoryProducts, opt => opt.MapFrom(src => src.Products)).ReverseMap();

            // Map from Product to CategoryProduct
            CreateMap<Product, CategoryProduct>()
                .ForMember(dest => dest.product, opt => opt.MapFrom(src => src));

            // Optionally, map from CategoryProduct to a DTO if needed
            // CreateMap<CategoryProduct, CategoryProductDto>().ReverseMap();
        }
    }
}
