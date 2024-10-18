using System;
namespace Application.Features.Queries.Orders.GetOrdersWhere
{
    public class GetOrdersWhereQueryResponse
    {
        public string Status { get; set; }
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}

