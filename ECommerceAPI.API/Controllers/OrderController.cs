using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListOrders()
        {
            var result = await _orderService.GetAllOrdersAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _orderService.GetOrderByIdAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere(string status)
        {
            var result = await _orderService.SearchOrdersByStatus(status);
            if (result == null)
                return null;
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto createOrderDto)
        {
            var result = await _orderService.CreateOrderAsync(createOrderDto);
            if (result)
                return Ok();
            return BadRequest("Could not create the order");
        }

        [HttpPut("byId")]
        public async Task<IActionResult> Update([FromBody] UpdateOrderDto updateOrderDto)
        {
            var result = await _orderService.UpdateOrderAsync(updateOrderDto);
            if (result)
                return Ok();
            return BadRequest("Could not update the order");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _orderService.DeleteOrderAsync(id);
            if (result)
                return Ok();
            return BadRequest("Could not delete the order");
        }
    }
}
