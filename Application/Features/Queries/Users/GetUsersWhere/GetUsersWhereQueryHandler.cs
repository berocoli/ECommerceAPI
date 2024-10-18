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
            // Pass name and nullable surname to the search method
            var userList = await _userService.SearchUsersByNameAsync(request.Name, request.Surname);

            // Map to response DTO
            var result = userList.Select(user => new GetUsersWhereQueryResponse
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Id = user.Id,
                Role = user.Role
            }).ToList();

            return result;
        }
    }
}
