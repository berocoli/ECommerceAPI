using Application.DTOs;

namespace Application.Services
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetAllOrdersAsync();
        Task<OrderDto> GetOrderByIdAsync(string id);
        Task<bool> CreateOrderAsync(CreateOrderDto createOrderDto);
        Task<bool> UpdateOrderAsync(UpdateOrderDto updateOrderDto);
        Task<bool> DeleteOrderAsync(string id);

    }
}

