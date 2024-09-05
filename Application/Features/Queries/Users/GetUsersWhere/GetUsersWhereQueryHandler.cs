using System;
using Application.Services;
using MediatR;

namespace Application.Features.Queries.Users.GetUsersWhere
{
    public class GetUsersWhereQueryHandler : IRequestHandler<GetUsersWhereQueryRequest, List<GetUsersWhereQueryResponse>>
    {
        private readonly IUserService _userService;
        public GetUsersWhereQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<List<GetUsersWhereQueryResponse>> Handle(GetUsersWhereQueryRequest request, CancellationToken cancellationToken)
        {
            var userList = await _userService.SearchUsersByNameAsync(request.Name);
            var result = userList.Select(userList => new GetUsersWhereQueryResponse
            {
                Email = userList.Email,
                Id = userList.Id,
                Role = userList.Role
            }).ToList();

            return result;
        }
    }
}

