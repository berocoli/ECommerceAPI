using Application.DTOs;
using Application.Services;
using MediatR;
namespace Application.Features.Queries.Orders.GetAllOrders
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQueryRequest, List<UserDto>>
    {
        private readonly IUserService _userService;
        public GetAllUsersQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<List<UserDto>> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var users = await _userService.GetAllUsersAsync();
            return users;
        }
    }
}
