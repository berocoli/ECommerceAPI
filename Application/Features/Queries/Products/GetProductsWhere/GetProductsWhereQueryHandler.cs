using System;
using Application.Services;
using MediatR;

namespace Application.Features.Queries.Products.GetProductsWhere
{
    public class GetProductsWhereQueryHandler : IRequestHandler<GetProductsWhereQueryRequest, List<GetProductsWhereQueryResponse>>
    {
        private readonly IProductService _productService;
        public GetProductsWhereQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<GetProductsWhereQueryResponse>> Handle(GetProductsWhereQueryRequest request, CancellationToken cancellationToken)
        {
            var productsList = await _productService.SearchProductsByNameAsync(request.Name);
            var result = productsList.Select(productsList => new GetProductsWhereQueryResponse
            {
                Name = productsList.Name,
                Stock = productsList.Stock,
                Price = productsList.Price,
                Description = productsList.Description
            }).ToList();

            return result;
        }
    }
}

