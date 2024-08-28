using System;
using Application.DTOs;
using Application.Services;
using MediatR;
namespace Application.Features.Queries.Products.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductDto>>
    {
        private readonly IProductService _productService;
        public GetAllProductsQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<ProductDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {

            var products = await _productService.GetAllProductsAsync();
            return products;
        }
    }
}

