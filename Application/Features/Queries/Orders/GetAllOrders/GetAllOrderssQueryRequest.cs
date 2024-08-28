using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Queries.Orders.GetAllOrders
{
    public class GetAllOrderssQueryRequest : IRequest<List<OrderDto>>
    {
        public GetAllOrderssQueryRequest()
        {
        }
    }
}

