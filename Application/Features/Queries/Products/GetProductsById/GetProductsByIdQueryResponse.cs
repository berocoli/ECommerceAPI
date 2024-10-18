using System;
namespace Application.Features.Queries.Products.GetProductsById
{
    public class GetProductsByIdQueryResponse
    {
        public string Name { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}

