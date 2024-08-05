using Domain.Entities.BaseEntity;

namespace Domain
{
    public class Product : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}

