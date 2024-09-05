using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Queries.Products.GetProductsById
{
    public class GetProductsByIdQueryRequest : IRequest<GetProductsByIdQueryResponse>
    {
        public string ProductId { get; set; }
    }
}

