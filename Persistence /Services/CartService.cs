using Application.DTOs;
using Application.DTOs.CartDto;
using Application.Exceptions;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain;
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

        public async Task<List<Guid>> CreateCartAuto(string? userId)
        {
            // Call the repository method to create carts
            var createdCarts = await _cartWriteRepository.CreateCartsForUsers(userId);

            if (createdCarts != null && createdCarts.Count > 0)
            {
                // Extract UserIds from the created carts
                var createdUser = createdCarts.Select(c => c.UserId).Distinct().ToList();

                return createdUser;
            }
            else
            {
                throw new FailException("No user were found without a cart. Check database for more information.");
            }
        }

        public async Task<CartResult> UpdateCartOrderId(string id, string userId, string orderId)
        {
            if (!Guid.TryParse(id, out var cartGuid))
                throw new FormatException("Wrong cart Id format.");
            if(!Guid.TryParse(userId, out var userGuid))
                throw new FormatException("Wrong user Id format.");
            if(!Guid.TryParse(orderId, out var orderGuid))
                throw new FormatException("Wrong order Id format.");
            var existingCart = await _cartReadRepository.GetSingleAsync(c => c.Id == cartGuid && c.UserId == userGuid);
            if(existingCart == null)
            {
                throw new FailException("Cart does not exist.");
            }

            var newOrder = await _orderReadRepository.GetByIdAsync(orderId);
            if (newOrder == null)
                throw new FailException("Order creation incomplete or wrong. Might wanna check about the nullable order foreign key.");
            var cartDto = new OrderCartDto
            {
                IsModifyable = false,
                OrderId = newOrder.Id.ToString()
            };
            _mapper.Map(cartDto, existingCart);
            var result = _cartWriteRepository.Update(existingCart);
            await _cartWriteRepository.SaveAsync();
            if (result)
            {
                return new CartResult
                {
                    CartCreated = "Cart updated successfully!"
                };
            }
            throw new FailException("Cart could not be updated. Check FK.");
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
            var cartItem = await _cartItemReadRepository.GetSingleAsync(ci => ci.ProductId == productGuid && ci.CartId == cartGuid);

            if (cartItem != null)
            {
                // Update quantity if product already is in the cart
                cartItem.Quantity += quantity;

                _cartItemWriteRepository.Update(cartItem);
                await _cartItemWriteRepository.SaveAsync();

                return new CartExistsResult
                {
                    CartExists = $"Quantity of {cartItem.Product.Name} increased by {quantity}."
                };
            }
            else
            {
                // Add new product to cart
                cartItem = new CartItem
                {
                    ProductId = productGuid,
                    Quantity = quantity,
                    CartId = cartGuid,
                };

                await _cartItemWriteRepository.AddAsync(cartItem);
                await _cartWriteRepository.SaveAsync();

                return new CartExistsResult { CartExists = "Product added to the cart successfully!" };
            }
        }

        public async Task<CartResult> UpdateQuantity(string cartId, string productId, int quantity)
        {
            // Validate cartId
            if (!Guid.TryParse(cartId, out var cartGuid))
            {
                throw new FailException("Quantity update failed. Please try again.");
            }

            // Validate productId
            if (!Guid.TryParse(productId, out var productGuid))
            {
                throw new FailException("Quantity update failed. Please try again.");
            }

            // Retrieve the existing cart
            var existingCart = await _cartReadRepository.GetSingleAsync(c => c.Id == cartGuid);
            if (existingCart == null)
            {
                throw new FailException("Cart not found for the user.");
            }

            // Retrieve the cart item for the specified product
            var cartItem = await _cartItemReadRepository.GetSingleAsync(ci => ci.CartId == cartGuid && ci.ProductId == productGuid);
            if (cartItem == null)
            {
                throw new FailException("Product not found in the cart.");
            }

            // Update the quantity
            cartItem.Quantity = quantity;

            // Update the cart item in the repository
            _cartItemWriteRepository.Update(cartItem);
            await _cartItemWriteRepository.SaveAsync();

            return new CartResult { CartCreated = "Quantity updated" };
        }

        public async Task<List<GetCartDto>> GetActiveCartsAsync()
        {
            var carts = await _cartReadRepository
                .GetAll()
                .Where(c => c.IsModifyable)
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
            var cart = await _cartReadRepository.GetWhere(c => c.UserId == userGuid && c.IsModifyable == true)
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
        

        public async Task<bool> RemoveCart(Guid cartId)
        {
            var cart = await _cartReadRepository.GetByIdAsync(cartId.ToString(), tracking: true);
            if (cart == null)
                return false;

            _cartWriteRepository.Remove(cart);
            await _cartWriteRepository.SaveAsync();
            return true;
        }

        public async Task<bool> RemoveCartItem(string cartItemId, string productId)
        {
            if (!Guid.TryParse(cartItemId, out var cartItemGuid))
            {
                throw new FailException("Id format is wrong");
            }
            if (!Guid.TryParse(productId, out var productGuid))
            {
                throw new FailException("Id format is wrong");
            }

            var cartItem = await _cartItemReadRepository
                .GetWhere(ci => ci.CartId == cartItemGuid && ci.ProductId == productGuid)
                .FirstOrDefaultAsync()
                ?? throw new FailException("Item couldn't be found in the cart.");

            // Instead of using the cartItemId here, use the actual cartItem
            _cartItemWriteRepository.Remove(cartItem);
            await _cartItemWriteRepository.SaveAsync();
            return true;
        }

        public async Task<bool> RemoveAllCartItems(string cartId)
        {
            if (!Guid.TryParse(cartId, out var cartGuid))
                throw new FailException("False Id format.");
            var cartItem = await _cartItemReadRepository.GetWhere(c => c.CartId == cartGuid)
                .ToListAsync();

            if(cartItem == null)
                throw new DeleteException("No item is in cart.");
            
            var result = _cartItemWriteRepository.RemoveRange(cartItem);
            await _cartItemWriteRepository.SaveAsync();

            return result;
        }
    }
}
