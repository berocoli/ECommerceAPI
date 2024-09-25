using System;
using System.IdentityModel.Tokens.Jwt;
using Application.DTOs.Token;

namespace Application.Services.TokenServices
{
    public interface ITokenHandler
    {
        TokenModel CreateAccessToken(int minutes, string id, string email, string name, string surname, bool role); 
    }
}


