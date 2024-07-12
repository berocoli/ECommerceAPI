﻿using System;
namespace Domain
{
    public class Product
    {
        public string Name { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }

        public ICollection<Order> orders { get; set; }

    }
}

