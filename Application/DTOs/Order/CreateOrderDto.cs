using System;
namespace Application.DTOs
{
    public class CreateOrderDto
    {
        public string UserId { get; set; }
        public string CartId { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}

