using System;
using Application.Repositories;
using Domain;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class CategoryReadRepository : ReadRepository<ProductsCategory>, ICategoryReadRepository
    {
        public CategoryReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

