using Application.DTOs;

namespace Application.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(string id);
        Task<List<ProductDto>> SearchProductsByNameAsync(string name);
        Task<bool> CreateProductsAsync(string categoryId, string name, double price, double stock, string description, string imageUrl);
        Task<bool> UpdateProductsAsync(string id, string categoryId, string name, double price, double stock, string description, string imageUrl);
        Task<bool> DeleteProductAsync(string id);
        Task<List<ProductDto>> GetAllProductsStorage();
        Task<ProductDto> GetProductAsJsonFunc(string id);
    }
}

