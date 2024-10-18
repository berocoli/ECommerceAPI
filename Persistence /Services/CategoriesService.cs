using Application.Repositories;
using Application.Services;
using AutoMapper;

namespace Persistence.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public CategoriesService(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository, IMapper mapper, IProductReadRepository productReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
            _mapper = mapper;
        }
    }
}

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

