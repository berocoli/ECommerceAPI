using System;
using Application.Services;
using MediatR;

namespace Application.Features.Commands.Users.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
    {
        private readonly IUserService _userService;
        public UpdateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _userService.UpdateUserAsync(request.Id, request.Name, request.Surname, request.EMail, request.Password, request.Role);
            if(result == false)
            {
                return new UpdateUserCommandResponse
                {
                    Message = "User update executed unsuccessfully."
                };
            }

            return new UpdateUserCommandResponse
            {
                Message = "User update executed successfully!"
            };
        }
    }
}

