using System;
namespace Application.DTOs
{
    public class OrderDto
    {
        public string Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}

