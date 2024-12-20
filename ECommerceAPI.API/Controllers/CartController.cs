using Application.DTOs;
using Application.DTOs.CartDto;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CartController : ControllerBase
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateCart([FromBody] CreateCartDto dto)
    {
        var result = await _cartService.CreateCartAsync(dto.UserId);
        return Ok(result);
    }

    [HttpPost("automatic")]
    public async Task<IActionResult> AutoCreate([FromBody] string? userId)
    {
        var result = await _cartService.CreateCartAuto(userId);
        return Ok(result);
    }

    [HttpPut("add")]
    public async Task<IActionResult> AddToCart([FromBody] UpdateCartDto dto)
    {
        var result = await _cartService.AddToCartAsync(dto.UserId, dto.CartId, dto.ProductId, dto.Quantity);
        return Ok(result);
    }

    [HttpPut("quantity")]
    public async Task<IActionResult> UpdateQuantity(string cartId,  string productId, int quantity)
    {
        var result = await _cartService.UpdateQuantity(cartId, productId, quantity);
        return Ok(result);
    }
                                                                
    [HttpGet("active")]                                         
    public async Task<IActionResult> GetActiveCarts()
    {
        var carts = await _cartService.GetActiveCartsAsync();
        return Ok(carts);
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetCartById(string userId)
    {
        var result = await _cartService.GetCartByIdAsync(userId);
        return Ok(result);
    }

    [HttpGet("byIdSP/{userId}")]
    public async Task<IActionResult> GetCartsByIdSP(string userId)
    {
        var result = await _cartService.GetCartsByIdSP(userId);
        return Ok(result);
    }

    [HttpDelete("remove-cart/{cartId}")]
    public async Task<IActionResult> RemoveCart(Guid cartId)
    {
        var result = await _cartService.RemoveCart(cartId);
        return Ok(result);
    }

    [HttpDelete("cartItem")]
    public async Task<IActionResult> RemoveCartItem(string cartItemId, string productId)
    {
        var result = await _cartService.RemoveCartItem(cartItemId, productId);
        return Ok(result);
    }

    [HttpDelete("deleteAllCartItems")]
    public async Task<IActionResult> RemoveAllCartItems(string cartId)
    {
        var result = await _cartService.RemoveAllCartItems(cartId);
        return Ok(result);
    }
}
