using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Queries.Products.GetAllProducts
{
    public class GetAllProductsQueryRequest : IRequest<List<ProductDto>>
    {
        public GetAllProductsQueryRequest()
        {
        }
    }
}

