using System;
namespace Application.DTOs
{
    public class CategoryDto
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public List<CategoryProduct> CategoryProducts { get; set; }
    }

    public class CategoryProduct
    {
        public ProductDto product { get; set; }
    }
}
