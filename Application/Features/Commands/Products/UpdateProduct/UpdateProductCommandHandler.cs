using System;
using Application.Services;
using MediatR;

namespace Application.Features.Commands.Products.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IProductService _productService;
        public UpdateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _productService.UpdateProductsAsync(request.UpdateProduct);
            if(result == false)
            {
                return new UpdateProductCommandResponse
                {
                    Message = "Product update execution failed."
                };
            }

            return new UpdateProductCommandResponse
            {
                Message = "Product update executed successfully!"
            };
        }
    }
}

