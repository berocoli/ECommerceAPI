using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Queries.Users.GetUsersById
{
    public class GetUsersByIdQueryRequest : IRequest<UserDto>
    {
        public Guid UserId { get; set; }
        public GetUsersByIdQueryRequest()
        {
            
        }
    }
}

