using System;
using Application.DTOs;
using Application.Services;
using MediatR;

namespace Application.Features.Queries.Users.GetUsersById
{
    public class GetUsersByIdQueryHandler : IRequestHandler<GetUsersByIdQueryRequest, List<UserDto>>
    {
        private readonly IUserService _userService;
        public GetUsersByIdQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public Task<List<UserDto>> Handle(GetUsersByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var users = _userService.GetUserByIdAsync(request.);
        }
    }
}

