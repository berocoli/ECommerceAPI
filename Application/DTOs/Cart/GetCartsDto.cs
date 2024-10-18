using System;
using System.Collections.Generic;

namespace Application.DTOs
{
    public class GetCartDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<CartProductDto> CartProducts { get; set; }
    }


    public class CartProductDto
    {
        public Guid ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
    }

}
