using Application.Exceptions;
using Application.Services;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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

            if (ordersList != null && ordersList.Any())
            {
                var result = ordersList.Select(o => new GetOrdersWhereQueryResponse
                {
                    Id = o.Id,
                    OrderId = o.Id,
                    CartId = o.CartId,
                    Status = o.Status,
                    UserId = o.UserId,
                    Address = o.Address,
                    Description = o.Description,
                    CreatedDate = o.CreatedDate,
                    UpdatedDate = o.UpdatedDate,
                    Cart = o.Cart
                }).ToList();

                return result;
            }

            throw new FailException("No order found for user.");
        }
    }
}
