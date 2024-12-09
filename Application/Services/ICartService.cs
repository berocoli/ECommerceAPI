using Application.DTOs;
using Application.DTOs.CartDto;

namespace Application.Services
{
    public interface ICartService
    {
        Task<CartResult> CreateCartAsync(string userId);
        Task<List<Guid>> CreateCartAuto(string? userId);
        Task<CartResult> AddToCartAsync(string userId, string cartId, string productId, int quantity);
        Task<CartResult> UpdateQuantity(string cartId, string productId, int quantity);
        Task<List<GetCartDto>> GetActiveCartsAsync();
        Task<GetCartDto> GetCartByIdAsync(string cartId);
        Task<List<GetCartDto>> GetCartsByIdSP(string userId);
        Task<bool> RemoveCart(Guid cartId);
        Task<bool> RemoveCartItem(string cartItemId, string productId);
        Task<bool> RemoveAllCartItems(string cartId);
        // Define other methods as needed
    }
}
