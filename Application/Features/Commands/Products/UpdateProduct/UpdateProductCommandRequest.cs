using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Products.UpdateProduct
{
    public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
    {
        public UpdateProductDto UpdateProduct { get; set; }
    }
}

