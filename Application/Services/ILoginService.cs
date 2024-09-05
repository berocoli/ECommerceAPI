using Application.DTOs.Token;
using Application.Features.LoginCustomer;

namespace Application.Services
{
    public interface ILoginService
    {
        Task<TokenModel> LoginHandler(string Email, string Password);
    }
}

