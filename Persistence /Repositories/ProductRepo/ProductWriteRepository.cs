using Application.Repositories;
using Domain;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        private readonly ECommerceAPIDbContext _context;
        public ProductWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> CreateProductFromSP()
        {
            throw new NotImplementedException();
        }
    }
}

