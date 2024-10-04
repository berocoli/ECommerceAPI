using Domain.Entities.BaseEntity;

namespace Domain
{
    public class ProductsCategory : BaseEntity
    {
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; } // Navigation property
    }
}
