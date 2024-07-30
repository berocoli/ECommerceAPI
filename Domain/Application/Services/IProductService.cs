using Application.DTOs;

namespace Application.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(string id);
        Task<List<ProductDto>> SearchProductsByNameAsync(string name);
        Task<bool> CreateProductsAsync(CreateProductDto createProductDto);
        Task<bool> UpdateProductsAsync(UpdateProductDto updateProductDto);
        Task<bool> DeleteProductAsync(DeleteProductDto deleteProductDto);
    }
}

