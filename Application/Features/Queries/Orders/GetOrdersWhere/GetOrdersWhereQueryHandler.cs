using System;
using Application.Services;
using MediatR;

namespace Application.Features.Queries.Orders.GetOrdersWhere
{
    public class GetOrdersWhereQueryHandler : IRequestHandler<GetOrdersWhereQueryRequest, List<GetOrdersWhereQueryResponse>>
    {
        private readonly IOrderService _orderService; 
        public GetOrdersWhereQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<List<GetOrdersWhereQueryResponse>> Handle(GetOrdersWhereQueryRequest request, CancellationToken cancellationToken)
        {
            var ordersList = await _orderService.SearchOrdersByStatus(request.Status);
            var result = ordersList.Select(ordersList => new GetOrdersWhereQueryResponse
            {
                Status = ordersList.Status,
                OrderId = ordersList.Id,
                UserId = ordersList.UserId,
                Address = ordersList.Address,
                Description = ordersList.Description
            }).ToList();

            return result;
        }
    }
}

