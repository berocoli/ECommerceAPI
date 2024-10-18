using Application.DTOs;

namespace Application.Services
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetAllOrdersAsync();
        Task<OrderDto> GetOrderByIdAsync(string id);
        Task<List<OrderDto>> SearchOrdersByStatus(string status);
        Task<bool> CreateOrderAsync(string userId, string cartId, string status, string address, string description);
        Task<bool> UpdateOrderAsync(string id, string status, string address, string description);
        Task<bool> DeleteOrderAsync(string id);

    }
}

