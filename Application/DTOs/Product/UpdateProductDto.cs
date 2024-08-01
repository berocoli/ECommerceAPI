using System;
namespace Application.DTOs
{
    public class UpdateProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }
        public double Description { get; set; }
    }
}

