﻿using Application.DTOs;
using Application.Features.Queries.Orders.GetAllOrders;
using Application.Features.Queries.Orders.GetOrdersById;
using Application.Features.Queries.Orders.GetOrdersWhere;
using Application.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly private IOrderService _orderService;
        private readonly IMediator mediator;

        public OrderController(IOrderService orderService, IMediator _mediator)
        {
            _orderService = orderService;
            mediator = _mediator;
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListOrders()
        {
            var response = await mediator.Send(new GetAllOrderssQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var request = new GetOrdersByIdQueryRequest { OrderId = id};
            GetOrdersByIdQueryResponse response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere(string status)
        {
            var request = new GetOrdersWhereQueryRequest { Status = status };
            List<GetOrdersWhereQueryResponse> response = await mediator.Send(request);
            return Ok(response);
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