using System;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CartItemWriteRepository : WriteRepository<CartItem>, ICartItemWriteRepository
    {
        public CartItemWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

