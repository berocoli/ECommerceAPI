using System;
using Application.Services;
using MediatR;

namespace Application.Features.Commands.Products.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly IProductService _productService;
        public CreateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _productService.CreateProductsAsync(request.Name, request.Price, request.Stock, request.Description);
            if(result == false)
            {
                return new CreateProductCommandResponse
                {
                    Message = "Product creation unsuccessfull."
                };
            }

            return new CreateProductCommandResponse
            {
                Message = "Product created successfully!"
            };
        }
    }
}

