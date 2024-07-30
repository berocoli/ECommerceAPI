using System;
namespace Application.DTOs
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }
        public double Description { get; set; }
    }
}

