using System;
using Application.Features.Commands.Users.CreateAdmin;
using Application.Services;
using MediatR;

namespace Application.Features.Commands.Users.CreateUser
{
    public class CreateAdminCommandHandler : IRequestHandler<CreateAdminCommandRequest, CreateAdminCommandResponse>
    {
        private readonly IUserService _userService;
        public CreateAdminCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateAdminCommandResponse> Handle(CreateAdminCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _userService.CreateAdminUserAsync(request.Name, request.Surname, request.EMail, request.Password, request.Role);
            if (result)
            {
                return new CreateAdminCommandResponse
                {
                    Message = "Successfully signed up!"
                };
            }

            return new CreateAdminCommandResponse
            {
                Message = "Sign up failed."
            };
        }
    }
}

