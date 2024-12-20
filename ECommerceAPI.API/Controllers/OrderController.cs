using Application.Features.Commands.Orders.CreateOrder;
using Application.Features.Commands.Orders.DeleteOrder;
using Application.Features.Commands.Orders.UpdateOrder;
using Application.Features.Queries.Orders.GetAllOrders;
using Application.Features.Queries.Orders.GetOrdersById;
using Application.Features.Queries.Orders.GetOrdersWhere;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    { 
        private readonly IMediator mediator;

        public OrderController(IMediator _mediator)
        {          
            mediator = _mediator;
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListOrders()
        {
            var response = await mediator.Send(new GetAllOrderssQueryRequest());
            return Ok(response);
        }

        [HttpGet("listById/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var request = new GetOrdersByIdQueryRequest { OrderId = id };
            GetOrdersByIdQueryResponse response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("search/{userId}")]
        public async Task<IActionResult> GetWhere(string userId)
        {
            var request = new GetOrdersWhereQueryRequest { UserId = userId };
            List<GetOrdersWhereQueryResponse> response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("insert")]
        public async Task<IActionResult> CreateOrder(CreateOrderCommandRequest createRequest)
        {
            var result = await mediator.Send(createRequest);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateOrderCommandRequest updateRequest)
        {
            var result = await mediator.Send(updateRequest);
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(DeleteOrderCommandRequest request)
        {
            var result = await mediator.Send(request);
            return Ok(result);
        }
    }
}