using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.DTOs.Cart;
using Domain;

namespace Application.Services
{
    public interface ICartService
    {
        Task<CartResult> CreateCartAsync(string userId, string productId, int quantity);
        Task<CartResult> AddToCartAsync(UpdateCartDto updateCartDto);
        Task<List<GetCartDto>> GetActiveCartsAsync();
        Task<int> CountActiveCartsAsync();
        Task<bool> RemoveCart(Guid cartId);
        Task<CartResult> CartHandler(string cartId, string userId, string productId, int quantity);
        // Define other methods as needed
    }
}
