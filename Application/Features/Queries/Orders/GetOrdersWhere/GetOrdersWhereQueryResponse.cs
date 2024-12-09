using System;
using Application.DTOs;
using Domain;

namespace Application.Features.Queries.Orders.GetOrdersWhere
{
    public class GetOrdersWhereQueryResponse
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public string CartId { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public GetCartDto Cart { get; set; }
    }
}

