using System;
using MediatR;

namespace Application.Features.Commands.Products.DeleteProduct
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandrResponse>
    {
        public string Id { get; set; }
    }
}

