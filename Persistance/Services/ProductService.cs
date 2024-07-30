using System;
using Application.DTOs;
using Application.Services;

namespace Persistance.Services
{
    public class ProductService : IProductService
    {
        public ProductService()
        {
        }

        public Task<bool> CreateProductsAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductAsync(DeleteProductDto deleteProductDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> SearchProductsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProductsAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}

