using Application.DTOs;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IUserReadRepository _userReadRepository;
        private readonly ICartReadRepository _cartReadRepository;
        public readonly IMapper _mapper;

        public OrderService(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, IUserReadRepository userReadRepository, ICartReadRepository cartReadRepository, IMapper mapper)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _userReadRepository = userReadRepository;
            _cartReadRepository = cartReadRepository;
            _mapper = mapper;
        }
                
        public async Task<List<OrderDto>> GetAllOrdersAsync()
        {
            var orders = await _orderReadRepository.GetAll().ToListAsync();
            return _mapper.Map<List<OrderDto>>(orders);
        }

        public async Task<OrderDto> GetOrderByIdAsync(string id)
        {
            var order = await _orderReadRepository.GetByIdAsync(id);
            if (order == null)
                return null;
            return _mapper.Map<OrderDto>(order);
        }

        public async Task<List<OrderDto>> SearchOrdersByStatus(string status)
        {
            var orders = await _orderReadRepository.GetWhere(o => o.Status.Contains(status)).ToListAsync();
            if (orders == null)
                return null;
            return _mapper.Map<List<OrderDto>>(orders);
        }

        public async Task<bool> CreateOrderAsync(string userId, string cartId, string status, string address, string description)
        {
            var createOrderDto = new CreateOrderDto
            {
                UserId = userId,
                CartId = cartId,
                Status = status,
                Address = address,
                Description = description
            };

            var user = await _userReadRepository.GetByIdAsync(userId);
            var cart = await _cartReadRepository.GetByIdAsync(cartId);
            var cartGuid = Guid.Parse(cartId);
            var existingOrder = await _orderReadRepository.GetSingleAsync(o => o.CartId == cartGuid);

            if (existingOrder != null)
            {
                return false;
            }

            if (user == null || cart == null || cart.UserId != user.Id)
            {
                return false;
            }
            
            var order = _mapper.Map<Order>(createOrderDto);
            var result = await _orderWriteRepository.AddAsync(order);
            await _orderWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateOrderAsync(string id, string status, string address, string description)
        {
            var order = await _orderReadRepository.GetByIdAsync(id);
            if (order == null)
                return false;

            var updateOrderDto = new UpdateOrderDto
            {
                Id = id,
                Status = status,
                Address = address,
                Description = description
            };

            _mapper.Map(updateOrderDto, order);
            var result = _orderWriteRepository.Update(order);
            await _orderWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteOrderAsync(string id)
        {
            var result = await _orderWriteRepository.RemoveAsync(id);
            await _orderWriteRepository.SaveAsync();
            return result;
        }
    }
}