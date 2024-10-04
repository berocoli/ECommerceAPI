using Domain.Entities.BaseEntity;

namespace Domain
{
    public class Product : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public ProductsCategory? Category { get; set; }

        public string Name { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Cart> CartItems { get; set; } // Navigation property
    }
}
