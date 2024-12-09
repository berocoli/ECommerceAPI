using System;
using Application.DTOs;
using Application.Exceptions;
using Application.Services;
using MediatR;

namespace Application.Features.Queries.Categories.GetCategoryById
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQueryRequest, GetByCategoryDto>
    {
        private readonly ICategoriesService _categoriesService;
        public GetCategoryByIdQueryHandler(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        public async Task<GetByCategoryDto> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var category = await _categoriesService.GetProductByCategoryId(request.Id);
            if(category == null)
            {
                throw new GetRequestFailedException();
            }
            return category;
        }
    }
}

