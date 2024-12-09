using System;
using Application.DTOs;

namespace Application.Features.Queries.Orders.GetOrdersById
{
    public class GetOrdersByIdQueryResponse
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public GetCartDto Cart { get; set; }
    }
}
