using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Queries.Users.GetUsersById
{
    public class GetUsersByIdQueryRequest : IRequest<GetUsersByIdQueryResponse>
    {
        public string UserId { get; set; }
    }
}

