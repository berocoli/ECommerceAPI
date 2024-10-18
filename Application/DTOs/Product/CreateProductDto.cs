using System;
namespace Application.DTOs
{
    public class CreateProductDto
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

