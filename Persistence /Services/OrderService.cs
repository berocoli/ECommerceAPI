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
        private readonly ICartWriteRepository _cartWriteRepository;
        private readonly ICartService cartService;
        public readonly IMapper _mapper;

        public OrderService(
            IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, IUserReadRepository userReadRepository, ICartReadRepository cartReadRepository, ICartWriteRepository cartWriteRepository, ICartService _cartService, IMapper mapper
            )
        {
            _orderReadRepository    = orderReadRepository;
            _orderWriteRepository   = orderWriteRepository;
            _userReadRepository     = userReadRepository;
            _cartReadRepository     = cartReadRepository;
            _cartWriteRepository    = cartWriteRepository;
            cartService             = _cartService;
            _mapper                 = mapper;
        }
                
        public async Task<List<OrderDto>> GetAllOrdersAsync()
        {
            var orders = await _orderReadRepository.GetAll()
                .Include(o => o.Cart)
                    .ThenInclude(c => c.CartItems)
                        .ThenInclude(ci => ci.Product)
                .ToListAsync();
            return _mapper.Map<List<OrderDto>>(orders);
        }

        public async Task<List<OrderDto>> GetOrderByIdAsync(string id)
        {
            if (!Guid.TryParse(id, out var orderGuid))
                return null;
            var order = await _orderReadRepository.GetWhere(o => o.Id == orderGuid)
                .Include(o => o.Cart)
                    .ThenInclude(c => c.CartItems)
                        .ThenInclude(ci => ci.Product)
                .ToListAsync();
            if (order == null)
                return null;
            return _mapper.Map<List<OrderDto>>(order);
        }

        public async Task<List<OrderDto>> SearchOrdersByUserId(string userId)
        {
            if(!Guid.TryParse(userId, out var userGuid))
                return null;
            
            var orders = await _orderReadRepository.GetWhere(o => o.UserId == userGuid)
                .Include(o => o.Cart)
                    .ThenInclude(c => c.CartItems)
                        .ThenInclude(ci => ci.Product)
                .ToListAsync();

            if (orders == null)
                return null;
            var orderDtos = _mapper.Map<List<OrderDto>>(orders);

            foreach(var dto in orderDtos)
            {
                if(dto.CreatedDate == DateTime.UnixEpoch)
                {
                    dto.CreatedDate = DateTime.Parse(null);
                    dto.UpdatedDate = DateTime.Parse(dto.UpdatedDate.ToString("yyyy-MM-dd HH:mm"));
                } else
                {
                    dto.UpdatedDate = DateTime.Parse(null);
                    dto.CreatedDate = DateTime.Parse(dto.CreatedDate.ToString("yyyy-MM-dd HH:mm"));
                }
            }

            return orderDtos;
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
                       
            var cartDto = new OrderCartDto
            {
                IsModifyable = false
            };

            _mapper.Map(cartDto, cart);
            _cartWriteRepository.Update(cart);
            await cartService.CreateCartAsync(userId);
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