using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Products.CreateProduct
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public CreateProductDto CreateProduct { get; set; }
    }
}

