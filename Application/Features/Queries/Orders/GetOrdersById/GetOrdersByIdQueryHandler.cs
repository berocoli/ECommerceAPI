using System;
using Application.DTOs;
using Application.Services;
using MediatR;

namespace Application.Features.Queries.Orders.GetOrdersById
{
    public class GetOrdersByIdQueryHandler : IRequestHandler<GetOrdersByIdQueryRequest, GetOrdersByIdQueryResponse>
    {
        private readonly IOrderService _orderService;
        public GetOrdersByIdQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetOrdersByIdQueryResponse> Handle(GetOrdersByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderService.GetOrderByIdAsync(request.OrderId);
            if(order == null)
            {
                return new GetOrdersByIdQueryFailResponse
                {
                    Message = "Order was not found!"
                };
            }
            return new GetOrdersByIdQueryResponse
            {
                UserId = order.Id,
                Address = order.Address,
                Description = order.Description,
                Status = order.Status
            };
        }
    }
}

