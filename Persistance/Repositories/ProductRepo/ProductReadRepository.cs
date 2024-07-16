using System;
using Application.Repositories;
using Domain;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

