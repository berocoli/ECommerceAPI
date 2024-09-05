using System;
using Application.DTOs;
using Application.Services;
using MediatR;

namespace Application.Features.Queries.Users.GetUsersById
{
    public class GetUsersByIdQueryHandler : IRequestHandler<GetUsersByIdQueryRequest, GetUsersByIdQueryResponse>
    {
        private readonly IUserService _userService;
        public GetUsersByIdQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<GetUsersByIdQueryResponse> Handle(GetUsersByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUserByIdAsync(request.UserId);
            return new GetUsersByIdQueryResponse
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Role = user.Role
            };
        }
    }
}

