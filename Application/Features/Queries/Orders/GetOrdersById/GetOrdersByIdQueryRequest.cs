using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Queries.Orders.GetOrdersById
{
    public class GetOrdersByIdQueryRequest : IRequest<GetOrdersByIdQueryResponse>
    {
        public string OrderId { get; set; }
    }
}

