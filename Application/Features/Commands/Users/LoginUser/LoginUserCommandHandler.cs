using System;
using Application.Exceptions;
using Application.Features.LoginCustomer;
using Application.Services;
using Domain;
using MediatR;

namespace Application.Features.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        private readonly ILoginService _loginService;
        public LoginUserCommandHandler(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            var token = await _loginService.LoginHandler(request.Email, request.Password);
            if (token == null)
            {
                throw new LoginFailException();
            }
            else
            {
                return new LoginUserSuccessCommandResponse()
                {
                    Token = token
                };
            }
        }
    }
}

