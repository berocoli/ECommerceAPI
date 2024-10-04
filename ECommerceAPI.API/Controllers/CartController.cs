using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        // GET: /<controller>/
        [HttpGet("getAllCarts")]
        public async Task<IActionResult> GetCarts()
        {
            var result = await _cartService.GetActiveCartsAsync();
            return Ok(result);
        }

        [HttpPost("addCart")]
        public async Task<IActionResult> CreateCart(string userId, string productId, int quantity)
        {
            var result = await _cartService.CreateCartAsync(userId, productId, quantity);
            return Ok(result);
        }

        [HttpGet("single")]
        public async Task<IActionResult> ExistingCart(string userId)
        {
            var result = await _cartService.ExistingCart(userId);
            return Ok(result);
        }
    }
}

