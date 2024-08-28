using System;
using Application.DTOs;
using Application.Services;
using MediatR;
namespace Application.Features.Queries.Orders.GetAllOrders
{
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrderssQueryRequest, List<OrderDto>>
    {
        private readonly IOrderService _orderService;
        public GetAllOrdersQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<List<OrderDto>> Handle(GetAllOrderssQueryRequest request, CancellationToken cancellationToken)
        {
            var orders = await _orderService.GetAllOrdersAsync();
            return orders;
        }
    }
}

