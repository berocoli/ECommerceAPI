using Application.DTOs;
using Application.DTOs.Cart;

namespace Application.Services
{
    public interface ICartService
    {
        Task<CartResult> CreateCartAsync(string userId);
        Task<CartResult> AddToCartAsync(string userId, string cartId, string productId, int quantity);
        Task<List<GetCartDto>> GetActiveCartsAsync();
        Task<int> CountActiveCartsAsync();
        Task<GetCartDto> GetCartByIdAsync(string cartId);
        Task<List<GetCartDto>> GetCartsByIdSP(string userId);
        Task<bool> RemoveCart(Guid cartId);
        // Define other methods as needed
    }
}
