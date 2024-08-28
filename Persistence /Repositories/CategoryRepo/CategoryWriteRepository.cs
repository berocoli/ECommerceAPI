using Application.Repositories;
using Domain;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CategoryWriteRepository : WriteRepository<ProductsCategory>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

