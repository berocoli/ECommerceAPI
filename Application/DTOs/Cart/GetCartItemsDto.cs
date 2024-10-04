using System;
namespace Application.DTOs
{
    public class GetCartItemsDto
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } // If you want product details
        public double ProductPrice { get; set; } // If you want product details
        public int Quantity { get; set; }
    }
}