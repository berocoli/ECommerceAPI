using System;
using Application.Services;
using MediatR;

namespace Application.Features.Commands.Products.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandrResponse>
    {
        private readonly IProductService _productService;
        public DeleteProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<DeleteProductCommandrResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _productService.DeleteProductAsync(request.Id);
            if (result == false)
            {
                return new DeleteProductCommandrResponse
                {
                    Message = "Product deletion unsuccessful."
                };
            }

            return new DeleteProductCommandrResponse
            {
                Message = "Product deleted successfully!"
            };
        }
    }
}

