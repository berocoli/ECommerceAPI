using System;
using Application.Repositories;
using Domain.Entities.BaseEntity;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class ProductDetailReadRepository : ReadRepository<ProductDetail>, IProductDetailReadRepository 
    {
        public ProductDetailReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

