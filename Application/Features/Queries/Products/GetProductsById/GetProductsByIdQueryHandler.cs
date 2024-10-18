using System;
using Application.DTOs;
using Application.Services;
using MediatR;

namespace Application.Features.Queries.Products.GetProductsById
{
    public class GetProductsByIdQueryHandler : IRequestHandler<GetProductsByIdQueryRequest,GetProductsByIdQueryResponse>
    {
        private readonly IProductService _productService;
        public GetProductsByIdQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<GetProductsByIdQueryResponse> Handle(GetProductsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetProductByIdAsync(request.ProductId);
            return new GetProductsByIdQueryResponse
            {
                Name = product.Name,
                Stock = product.Stock,
                Price = product.Price,
                Description = product.Description 
            };                     
        }
    }
}

