using Application.DTOs;
using Application.Repositories.CartRepo;
using Application.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class CartService : ICartService
    {
        private readonly ICartReadRepository _cartReadRepository;
        private readonly ICartWriteRepository _cartWriteRepository;
        private readonly IMapper _mapper;

        public CartService( ICartReadRepository cartReadRepository, ICartWriteRepository cartWriteRepository, IMapper mapper)
        {
            _cartReadRepository = cartReadRepository;
            _cartWriteRepository = cartWriteRepository;
            _mapper = mapper;
        }

        public async Task<GetCartsDto> CountActiveCartsAsync()
        {
            var activeCarts = await _cartReadRepository.GetAll().CountAsync();
            if (activeCarts == null)
            {
                return null;
            }
            return _mapper.Map<GetCartsDto>(activeCarts);
        }

        public async Task<List<GetCartsDto>> GetActiveCartsAsync()
        {
            // Fetch all carts including their associated CartItems
            var carts = await _cartReadRepository.GetAll().ToListAsync();
            // Map the list of carts to GetCartsDto
            return _mapper.Map<List<GetCartsDto>>(carts);
        }

        public async Task<Cart> ExistingCart(string userId)
        {
            var userGuid = Guid.Parse(userId);
            var existingCart = await _cartReadRepository.GetSingleAsync(c => c.UserId == userGuid);
            return existingCart;
        }

        public async Task<CreateCartDto> CreateCartAsync(string userId, string productId, int quantity)
        {
            var userGuid = Guid.Parse(userId);
            var existingCart = await _cartReadRepository.GetSingleAsync(c => c.UserId == userGuid);

            if(existingCart != null)
            {
                return new CreateCartDto
                {
                    Message = "User already has a cart!"
                };
            }

            return new CreateCartDto
            {
                Message = "Product added to your cart!"
            };
            //var userGuid = Guid.Parse(userId);
            //var existingCart = await _cartReadRepository.GetSingleAsync(c => c.UserId == userGuid);

            //if (existingCart != null)
            //{
            //    var createCartDto = new CreateCartDto
            //    {
            //        CartId = existingCart.Id.ToString(),
            //        ProductId = productId,
            //        Quantity = quantity
            //    };
            //    var cartItem = _mapper.Map<Cart>(createCartDto);

            //    return new CartResult
            //    {
            //        CartItemResult = cartItem,
            //    };
            //}
            //else
            //{
            //    var cartId = Guid.NewGuid().ToString();
            //    var createCartDto = new CreateCartDto
            //    {
            //        CartId = cartId,
            //        UserId = userId,
            //        ProductId = productId,
            //        Quantity = quantity
            //    };
            //    var cart = _mapper.Map<Cart>(createCartDto);
            //    var cartResult = await _cartWriteRepository.AddAsync(cart);

            //    await _cartWriteRepository.SaveAsync();
            //    var cartItem = _mapper.Map<Cart>(createCartDto);

            //    return new CartResult
            //    {
            //        CartItemResult = cartItem
            //    };
            //}
        }

        public Task<bool> AddToCartAsync(string productId) 
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveCart()
        {
            throw new NotImplementedException();
        }
    }
}

