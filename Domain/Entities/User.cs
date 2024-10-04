﻿using System.Collections.Generic;
using Domain.Entities.BaseEntity;

namespace Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }

        public ICollection<Order>? Orders { get; set; } // Navigation property
        public Cart? Cart { get; set; } // Navigation property (one-to-one relationship)
    }
}
