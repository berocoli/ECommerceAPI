using System;
using Application.DTOs;

namespace Application.Services
{
    public interface ILoginService
    {
        Task<CustomerDto> LoginHandler(string Email, string Password);
    }                       
}

