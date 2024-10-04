using System;
using Application.Repositories.CartRepo;
using Domain;
using Persistence.Contexts;

namespace Persistence.Repositories.CartRepo
{
    public class CartWriteRepository : WriteRepository<Cart>, ICartWriteRepository
    {
        public CartWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

