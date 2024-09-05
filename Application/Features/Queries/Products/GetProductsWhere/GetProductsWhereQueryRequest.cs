using System;
using MediatR;

namespace Application.Features.Queries.Products.GetProductsWhere
{
    public class GetProductsWhereQueryRequest : IRequest<List<GetProductsWhereQueryResponse>>
    {
        public string Name { get; set; }
    }
}

