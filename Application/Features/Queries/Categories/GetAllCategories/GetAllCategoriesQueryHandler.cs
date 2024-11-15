using System;
using Application.DTOs;
using Application.Exceptions;
using Application.Services;
using MediatR;

namespace Application.Features.Queries.Categories.GetAllCategories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQueryRequest, List<CategoryDto>>
    {
        private readonly ICategoriesService _categoriesService;
        public GetAllCategoriesQueryHandler(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        public async Task<List<CategoryDto>> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var categories = await _categoriesService.GetAllCategories();
            if(categories == null)
            {
                throw new GetAllFailException();
            }
            return categories;
        }
    }
}

