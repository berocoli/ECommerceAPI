using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Queries.Categories.GetAllCategories
{
    public class GetAllCategoriesQueryRequest : IRequest<List<GetByCategoryDto>>
    {
        public GetAllCategoriesQueryRequest()
        {
        }
    }
}

