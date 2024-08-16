using System;
namespace Application.Services.TokenServices
{
    public interface ITokenService
    {
        Task<string> TokenGenerator(string Email);
    }
}

