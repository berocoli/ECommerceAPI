using System;
namespace Application.DTOs
{
    public class GetByCategoryDto
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public List<ProductDtoForGetCategories> Products { get; set; }
    }

    public class ProductDtoForGetCategories
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Stock { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

}


