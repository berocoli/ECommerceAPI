using System;
namespace Application.Services.TokenServices
{
    public interface ITokenService
    {
        JwtSecurityToken TokenGenerator(string Email);
    }
}

