using Application.DTOs.Token;

namespace Application.Services
{
    public interface ILoginService
    {
        Task<TokenModel> LoginHandler(string Email, string Password);
    }
}

