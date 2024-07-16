using System;
using Domain.Entities.BaseEntity;
namespace Domain
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}

