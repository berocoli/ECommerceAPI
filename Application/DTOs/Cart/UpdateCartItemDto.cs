﻿using System;
namespace Application.DTOs.Cart
{
    public class UpdateCartItemDto
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

