using Application.DTOs;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IUserReadRepository _userReadRepository;
        private readonly ICartReadRepository _cartReadRepository;
        private readonly ICartWriteRepository _cartWriteRepository;
        private readonly ICartItemReadRepository _cartItemReadRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly ICartService cartService;
        private readonly IProductService productService;
        private readonly ECommerceAPIDbContext _dbContext;
        public readonly IMapper _mapper;

        public OrderService(
            IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, IUserReadRepository userReadRepository, ICartReadRepository cartReadRepository, ICartWriteRepository cartWriteRepository,
            ICartItemReadRepository cartItemReadRepository, IProductReadRepository productReadRepository, ICartService _cartService, IProductService _productService, ECommerceAPIDbContext dbContext, IMapper mapper
            )
        {
            _orderReadRepository    = orderReadRepository;
            _orderWriteRepository   = orderWriteRepository;
            _userReadRepository     = userReadRepository;
            _cartReadRepository     = cartReadRepository;
            _cartWriteRepository    = cartWriteRepository;
            _cartItemReadRepository = cartItemReadRepository;
            _productReadRepository  = productReadRepository;
            cartService             = _cartService;
            productService          = _productService;
            _dbContext = dbContext;
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
                    dto.CreatedDate = DateTime.MinValue;
                    dto.UpdatedDate = DateTime.Parse(dto.UpdatedDate.ToString("yyyy-MM-dd HH:mm"));
                } else
                {
                    dto.UpdatedDate = DateTime.MinValue;
                    dto.CreatedDate = DateTime.Parse(dto.CreatedDate.ToString("yyyy-MM-dd HH:mm"));
                }
            }

            return orderDtos;
        }

        public async Task<bool> CreateOrderAsync(string userId, string cartId, string status, string address, string description)
        {
            if (!Guid.TryParse(userId, out var userGuid))
                throw new FormatException("Wrong Guid format.");
            if (!Guid.TryParse(cartId, out var cartGuid))
                throw new FormatException("Wrong Guid format.");
            // Validate input and load necessary entities
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

            // Here is where we start a transaction
            // Assuming you have access to the DbContext used by these repositories:
            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    // Create the order and save
                    var result = await _orderWriteRepository.AddAsync(order);
                    await _orderWriteRepository.SaveAsync();

                    // Once the order is persisted, update the cart information
                    var finalOrder = await _orderReadRepository.GetSingleAsync(o => o.CartId == cartGuid);
                    var finalOrderId = finalOrder.Id.ToString();

                    // Create a new cart for the user and update the old cart's orderId
                    await cartService.CreateCartAsync(userId);
                    await cartService.UpdateCartOrderId(cartId, userId, finalOrderId);

                    // Update product stocks based on the items in the cart
                    var cartProducts = await _cartItemReadRepository.GetWhere(ci => ci.CartId == cartGuid)
                        .Include(ci => ci.Product)
                        .ToListAsync();
                    foreach (var cartProduct in cartProducts)
                    {
                        var newStock = cartProduct.Product.Stock - cartProduct.Quantity;
                        var productId = cartProduct.ProductId.ToString();
                        await productService.UpdateProductStock(productId, newStock);
                    }

                    // If all operations succeeded, commit the transaction
                    await transaction.CommitAsync();

                    return result;
                }
                catch
                {
                    // If an error occurred at any point, roll back the transaction
                    await transaction.RollbackAsync();
                    throw; // Rethrow the exception to handle it upstream or log it
                }
            }
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