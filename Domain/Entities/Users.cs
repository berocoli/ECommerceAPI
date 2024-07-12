using System;
using Domain.Entities.BaseEntity;

namespace Domain
{
    public class Users : BaseEntity
    {
        public bool Admin { get; set; }
        public bool ActiveOrNot { get; set; }

        public Customer customer { get; set; }
    }
}

