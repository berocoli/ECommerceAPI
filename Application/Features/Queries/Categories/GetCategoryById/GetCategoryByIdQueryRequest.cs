    using System;
    using Application.DTOs;
    using MediatR;

    namespace Application.Features.Queries.Categories.GetCategoryById
    {
        public class GetCategoryByIdQueryRequest : IRequest<GetByCategoryDto>
        {
            public string Id { get; set; }
        }
    }

