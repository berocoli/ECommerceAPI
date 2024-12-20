using Application.DTOs;

namespace Application.Services
{
    public interface ICategoriesService
    {
        Task<List<GetByCategoryDto>> GetAllCategories();
        Task<List<GetByCategoryDto>> GetProductsByCategories();
        Task<GetByCategoryDto> GetProductByCategoryId(string productId);
        Task<CategoryDto> GetProductsByCategoryName(string categoryName);
        Task<bool> CreateCategory(string categoryName, bool isActive);
        Task<bool> UpdateCategory(string categoryName, bool isActive);
        Task<bool> DeleteCategory(string id);
    }
}
