using Application.DTOs;
using Application.DTOs.Cart;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories;

namespace Persistence.Services
{
    public class CartService : ICartService
    {
        private readonly ICartReadRepository _cartReadRepository;
        private readonly ICartWriteRepository _cartWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly ICartItemReadRepository _cartItemReadRepository;
        private readonly ICartItemWriteRepository _cartItemWriteRepository;
        private readonly IMapper _mapper;

        public CartService(ICartReadRepository cartReadRepository, ICartWriteRepository cartWriteRepository,
            IProductReadRepository productReadRepository, ICartItemReadRepository cartItemReadRepository, ICartItemWriteRepository cartItemWriteRepository, IMapper mapper)
        {
            _cartReadRepository = cartReadRepository;
            _cartWriteRepository = cartWriteRepository;
            _productReadRepository = productReadRepository;
            _cartItemReadRepository = cartItemReadRepository;
            _cartItemWriteRepository = cartItemWriteRepository;
            _mapper = mapper;
        }

        public async Task<CartResult> CreateCartAsync(string userId)
        {
            if (!Guid.TryParse(userId, out var userGuid))
                return new CartResult { Error = "Invalid user ID." };

            // Check if the user already has a cart
            var existingCart = await _cartReadRepository.GetSingleAsync(c => c.UserId == userGuid);

            if (existingCart != null)
            {
                return new CartResult { Error = "User already has a cart!" };
            }

            // Create a new cart
            var cartDto = new CreateCartDto
            { 
                UserId = userId,
            };

            var cart = _mapper.Map<Cart>(cartDto);
            await _cartWriteRepository.AddAsync(cart);
            await _cartWriteRepository.SaveAsync();

            return new CartResult { CartExists = "Cart created and product added successfully!" };
        }

        public async Task<CartResult> AddToCartAsync(string userId, string cartId, string productId, int quantity)
        {
            if(!Guid.TryParse(userId, out var userGuid))
            {
                return new CartResult { Error = "Invalid User ID." };
            }
            if(!Guid.TryParse(productId, out var productGuid))
            {
                return new CartResult { Error = "Invalid product ID." };
            }
            if(!Guid.TryParse(cartId, out var cartGuid))
            {
                return new CartResult { Error = "Invalid Cart ID." };
            }

            // Fetch the user's existing cart with products
            var existingCart = _cartReadRepository.GetWhere(c => c.UserId == userGuid);

            if (existingCart == null)
            {
                return new CartResult { Error = "Cart not found for the user!" };
            }

            // Verify the product exists
            var product = await _productReadRepository.GetByIdAsync(productId);
            if (product == null)
            {
                return new CartResult { Error = "Product not found!" };
            }

            // Check if the product is already in the cart
            var cartItem = await _cartItemReadRepository.GetSingleAsync(ci => ci.ProductId == productGuid);
            
            if (cartItem != null)
            {
                // Update quantity if product already is in the cart
                cartItem.Quantity += quantity;
            }
            else
            {
                // Add new product to cart
                cartItem.ProductId = productGuid;
                cartItem.Quantity = quantity;
            }
            var cartDto = _mapper.Map<CartItem>(cartItem);
            await _cartItemWriteRepository.AddAsync(cartDto);
            await _cartWriteRepository.SaveAsync();

            return new CartResult { CartExists = "Product added to the cart successfully!" };
        }

        public async Task<List<GetCartDto>> GetActiveCartsAsync()
        {
            var carts = await _cartReadRepository
                .GetAll()
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .ToListAsync();

            return _mapper.Map<List<GetCartDto>>(carts);
        }


        public async Task<int> CountActiveCartsAsync()
        {
            return await _cartReadRepository.GetAll().CountAsync();
        }

        public async Task<bool> RemoveCart(Guid cartId)
        {
            var cart = await _cartReadRepository.GetByIdAsync(cartId.ToString(), tracking: true);
            if (cart == null)
                return false;

            _cartWriteRepository.Remove(cart);
            await _cartWriteRepository.SaveAsync();
            return true;
        }
    }
}
