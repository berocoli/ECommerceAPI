using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Products.CreateProduct
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

