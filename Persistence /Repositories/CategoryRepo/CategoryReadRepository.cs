using Application.Repositories;
using Domain;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CategoryReadRepository : ReadRepository<ProductsCategory>, ICategoryReadRepository
    {
        public CategoryReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

