using System;
using Application.DTOs;
using Application.DTOs.Cart;

namespace Application.Services
{
    public interface ICartService
    {
        Task<GetCartsDto> CountActiveCartsAsync();
        Task<List<GetCartsDto>> GetActiveCartsAsync();
        Task<CreateCartDto> CreateCartAsync(string userId, string productId, int quantity);
        Task<Cart> ExistingCart(string userId);
        Task<bool> AddToCartAsync(string productId);
        Task<bool> RemoveCart();
    }
}

