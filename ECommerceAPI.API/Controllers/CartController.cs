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
         var result = await _cartService.CreateCartAsync(dto.UserId, dto.ProductId, dto.Quantity);
         return Ok(result);
     }

    [HttpPost("add")]
    public async Task<IActionResult> AddToCart([FromBody] UpdateCartDto dto)
    {
        var result = await _cartService.AddToCartAsync(dto);
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

    [HttpDelete("{cartId}")]
    public async Task<IActionResult> RemoveCart(Guid cartId)
    {
        var result = await _cartService.RemoveCart(cartId);
        return Ok(result);
    }
}
