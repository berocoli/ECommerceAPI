using Application.DTOs;

namespace Application.Services
{
    public interface ICategoriesService
    {
        Task<List<CategoryDto>> GetAllCategories();
        Task<List<CategoryDto>> GetProductsByCategories();
        Task<CategoryDto> GetProductByCategoryId(string productId);
        // Added Method
        Task<CategoryDto> GetProductsByCategoryName(string categoryName);
        Task<bool> CreateCategory(string categoryName);
        Task<bool> UpdateCategory(string categoryName);
        Task<bool> DeleteCategory(string id);
    }
}
