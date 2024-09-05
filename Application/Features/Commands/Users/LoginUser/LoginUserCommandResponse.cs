using System;
using Application.DTOs.Token;

namespace Application.Features.LoginCustomer
{
    public class LoginUserCommandResponse
    {
     
    }
    public class LoginUserSuccessCommandResponse : LoginUserCommandResponse
    {
        public TokenModel Token { get; set; }
    }
    public class LoginUserFailCommandResponse : LoginUserCommandResponse
    {
        public string Message { get; set; }
    }
}

