using Application.DTOs;
using Application.DTOs.Product.Details;

namespace Application.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(string id);
        Task<List<ProductDto>> SearchProductsByNameAsync(string name);
        Task<List<RandomizedProductDto>> Randomizer();
        Task<bool> InsertRange(List<CreateProductDto> products);
        Task<bool> CreateProductsAsync(string categoryId, string name, double price, double stock, string description, string imageUrl);
        Task<bool> UpdateProductsAsync(string id, string categoryId, string name, double price, double stock, string description, string imageUrl);
        Task<bool> UpdateProductStock(string id, double newStock);
        Task<bool> DeleteProductAsync(string id);
        Task<List<ProductDto>> GetAllProductsStorage();
        Task<ProductDto> GetProductAsJsonFunc(string id);
        Task<ProductDetailDto> GetProductDetails(string id);
        Task<bool> CreateProductDetailsAsync(string id, string detail1, string detail2, string detail3);
        Task<bool> UpdateProductDetails(string id, string detail1, string detail2, string detail3);
    }
}

