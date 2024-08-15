using System;
namespace Application.Services.TokenServices
{
    public interface ITokenService
    {
        string TokenGenerator(string Email);
    }
}

