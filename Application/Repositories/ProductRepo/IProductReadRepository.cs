using Domain;
namespace Application.Repositories
{
    public interface IProductReadRepository : IReadRepository<Product>
    {
        Task<List<Product>> GetFromStoredProcedureAsync(bool tracking = true);
        Task<Product> GetProductAsJsonAsync(string id);
    }
}

