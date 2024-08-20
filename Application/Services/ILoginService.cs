using System;
using Application.DTOs.Token;
using Application.DTOs;

namespace Application.Services
{
    public interface ILoginService
    {
        Task<LoginUserCommandResponse> LoginHandler(string Email, string Password);
    }
    public class LoginUserCommandResponse
    {
        
        
    }
    public class LoginUserCommandSucceededResponse : LoginUserCommandResponse
    {
        public TokenModel Token { get; set; }
    }
    public class LoginUserCommandErrorResponse : LoginUserCommandResponse
    {
        public string Message { get; set; }
    }
}

