using Application.DTOs;
using Application.DTOs.Cart;
using Application.Exceptions;
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
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IMapper _mapper;

        public CartService(ICartReadRepository cartReadRepository, ICartWriteRepository cartWriteRepository,
            IProductReadRepository productReadRepository, ICartItemReadRepository cartItemReadRepository, ICartItemWriteRepository cartItemWriteRepository, IOrderReadRepository orderReadRepository, IMapper mapper)
        {
            _cartReadRepository = cartReadRepository;
            _cartWriteRepository = cartWriteRepository;
            _productReadRepository = productReadRepository;
            _cartItemReadRepository = cartItemReadRepository;
            _cartItemWriteRepository = cartItemWriteRepository;
            _orderReadRepository = orderReadRepository;
            _mapper = mapper;
        }

        public async Task<CartResult> CreateCartAsync(string userId)
        {            
            // Create a new cart
            var cartDto = new CreateCartDto
            { 
                UserId = userId,
            };

            var cart = _mapper.Map<Cart>(cartDto);
            await _cartWriteRepository.AddAsync(cart);
            
            await _cartWriteRepository.SaveAsync();

            return new CartExistsResult { CartExists = "Cart created and product added successfully!" };
        }

        public async Task<CartResult> AddToCartAsync(string userId, string cartId, string productId, int quantity)
        {
            if (!Guid.TryParse(userId, out var userGuid))
            {
                return new CartErrorResult { Error = "Invalid User ID." };
            }
            if (!Guid.TryParse(productId, out var productGuid))
            {
                return new CartErrorResult { Error = "Invalid product ID." };
            }
            if (!Guid.TryParse(cartId, out var cartGuid))
            {
                return new CartErrorResult { Error = "Invalid Cart ID." };
            }

            // Fetch the user's existing cart with products
            var existingCart = await _cartReadRepository.GetSingleAsync(c => c.Id == cartGuid && c.UserId == userGuid); 
            if (existingCart == null)
            {
                return new CartErrorResult { Error = "Cart not found for the user!" };
            }

            // Verify the product exists
            var product = await _productReadRepository.GetByIdAsync(productId);
            if (product == null)
            {
                return new CartErrorResult { Error = "Product not found!" };
            }

            // Check if the product is already in the cart
            var cartItem = await _cartItemReadRepository.GetSingleAsync(ci => ci.ProductId == productGuid && ci.CartId == cartGuid); // ensure correct cart id too

            if (cartItem != null)
            {
                // Update quantity if product already is in the cart
                cartItem.Quantity += quantity;
                cartItem.Product.Stock -= quantity;
            }
            else
            {
                // Add new product to cart
                cartItem = new CartItem // Ensure initialization
                {
                    ProductId = productGuid,
                    Quantity = quantity,
                    CartId = cartGuid,
                };
                // cartItem.Product.Stock -= quantity;
            }

            await _cartItemWriteRepository.AddAsync(cartItem);
            await _cartWriteRepository.SaveAsync();

            return new CartExistsResult { CartExists = "Product added to the cart successfully!"};
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

        public async Task<GetCartDto> GetCartByIdAsync(string userId)
        {
            if(!Guid.TryParse(userId, out var userGuid))
            {
                return null;
            }
            var cart = await _cartReadRepository.GetWhere(c => c.UserId == userGuid)
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync();
            return _mapper.Map<GetCartDto>(cart);
        }

        public async Task<List<GetCartDto>> GetCartsByIdSP(string userId)
        {
            var cart = await _cartReadRepository.GetCartsByIdAsyncSP(userId);
            if (cart == null)
            {
                throw new SearchedNotFoundException();
            }
            return _mapper.Map<List<GetCartDto>>(cart);
        }
        
        public async Task<int> CountActiveCartsAsync()
        {
            var activeCarts = _cartReadRepository.GetWhere(c => c.IsModifyable == true).Count();
            _mapper.Map<GetCartDto>(activeCarts);
            return activeCarts;
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
