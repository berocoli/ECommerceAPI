using System;
using Domain.Entities.BaseEntity;

namespace Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}

