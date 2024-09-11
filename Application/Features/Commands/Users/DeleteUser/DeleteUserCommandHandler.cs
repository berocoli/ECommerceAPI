using System;
using Application.Services;
using MediatR;

namespace Application.Features.Commands.Users.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, DeleteUserCommandResponse>
    {
        private readonly IUserService _userService;
        public DeleteUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _userService.DeleteUserAsync(request.Id);
            if(result == false)
            {
                return new DeleteUserCommandResponse
                {
                    Message = "User couldn't be deleted."
                };
            }

            return new DeleteUserCommandResponse
            {
                Message = "User successfully deleted!"
            };
        }
    }
}

