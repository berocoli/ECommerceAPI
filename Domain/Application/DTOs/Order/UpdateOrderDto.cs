﻿using System;
namespace Application.DTOs
{
    public class UpdateOrderDto
    {
        public Guid CustomerId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}

