using System;
namespace Domain.Entities.BaseEntity
{
    public class ProductDetail : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public string ProductDetail1 { get; set; }
        public string ProductDetail2 { get; set; }
        public string ProductDetail3 { get; set; }
    }
}
