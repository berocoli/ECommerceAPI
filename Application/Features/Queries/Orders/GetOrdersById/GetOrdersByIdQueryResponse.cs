using System;
namespace Application.Features.Queries.Orders.GetOrdersById
{
    public class GetOrdersByIdQueryResponse
    {
        public string UserId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    public class GetOrdersByIdQueryFailResponse : GetOrdersByIdQueryResponse
    {
        public string Message { get; set; }
    }
}

