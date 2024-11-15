using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Queries.Categories.GetAllCategories
{
    public class GetAllCategoriesQueryRequest : IRequest<List<CategoryDto>>
    {
        public GetAllCategoriesQueryRequest()
        {
        }
    }
}

