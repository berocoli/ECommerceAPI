using Application.Repositories;
using Domain;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class CategoryWriteRepository : WriteRepository<ProductsCategory>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

