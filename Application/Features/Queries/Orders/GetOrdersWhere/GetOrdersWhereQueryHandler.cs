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
            var ordersList = await _orderService.SearchOrdersByUserId(request.UserId);
            var result = ordersList.Select(ordersList => new GetOrdersWhereQueryResponse
            {
                Id = ordersList.Id,
                OrderId = ordersList.Id,
                CartId = ordersList.CartId,
                Status = ordersList.Status,                
                UserId = ordersList.UserId,
                Address = ordersList.Address,
                Description = ordersList.Description,
                CreatedDate = ordersList.CreatedDate,
                UpdatedDate = ordersList.UpdatedDate,
                Cart = ordersList.Cart,           
            }).ToList();

            return result;
        }
    }
}

