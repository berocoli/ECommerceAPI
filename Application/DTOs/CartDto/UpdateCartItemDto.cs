using System;
namespace Application.DTOs.CartDto
{
    public class UpdateCartItemDto
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

