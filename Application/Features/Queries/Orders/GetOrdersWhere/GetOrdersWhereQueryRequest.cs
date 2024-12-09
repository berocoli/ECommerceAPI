using System;
using MediatR;

namespace Application.Features.Queries.Orders.GetOrdersWhere
{
    public class GetOrdersWhereQueryRequest : IRequest<List<GetOrdersWhereQueryResponse>>
    {
        public string UserId { get; set; }
    }
}

