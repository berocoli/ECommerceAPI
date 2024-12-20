using System;
using Application.Repositories;
using Domain.Entities.BaseEntity;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class ProductDetailWriteRepository : WriteRepository<ProductDetail>, IProductDetailWriteRepository
    {
        public ProductDetailWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

