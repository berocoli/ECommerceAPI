using Application.DTOs;
using Application.DTOs.Cart;
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

    [HttpPost("add")]
    public async Task<IActionResult> AddToCart([FromBody] UpdateCartDto dto)
    {
        var result = await _cartService.AddToCartAsync(dto.UserId, dto.CartId, dto.ProductId, dto.Quantity);
        return Ok(result);
    }

    [HttpGet("active")]
    public async Task<IActionResult> GetActiveCarts()
    {
        var carts = await _cartService.GetActiveCartsAsync();
        return Ok(carts);
    }

    [HttpGet("count")]
    public async Task<IActionResult> CountActiveCarts()
    {
        var count = await _cartService.CountActiveCartsAsync();
        return Ok(count);
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetCartById(string userId)
    {
        var result = await _cartService.GetCartByIdAsync(userId);
        return Ok(result);
    }

    [HttpGet("byIdSP{userId}")]
    public async Task<IActionResult> GetCartsByIdSP(string userId)
    {
        var result = await _cartService.GetCartsByIdSP(userId);
        return Ok(result);
    }

    [HttpDelete("{cartId}")]
    public async Task<IActionResult> RemoveCart(Guid cartId)
    {
        var result = await _cartService.RemoveCart(cartId);
        return Ok(result);
    }
}
