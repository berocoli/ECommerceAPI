using System;
using Application.Services;
using MediatR;

namespace Application.Features.Commands.Users.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly IUserService _userService;
        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _userService.CreateUserAsync(request.Name, request.Surname, request.EMail, request.Password);
            if(result)
            {
                return new CreateUserCommandResponse
                {
                    Message = "Sign up failed."
                };
            }

            return new CreateUserCommandResponse
            {
                Message = "Successfully signed up!"
            };
        }
    }
}

