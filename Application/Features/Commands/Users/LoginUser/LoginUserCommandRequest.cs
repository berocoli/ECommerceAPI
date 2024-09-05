using System;
using MediatR;

namespace Application.Features.LoginCustomer
{
    public class LoginUserCommandRequest : IRequest<LoginUserCommandResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

