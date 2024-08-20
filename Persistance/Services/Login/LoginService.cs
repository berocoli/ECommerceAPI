using System;
using System.Threading.Tasks;
using Infrastructure.Operations;
using AutoMapper;
using Application.DTOs;
using Application.Services;
using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Application.Services.TokenServices;
using Application.DTOs.Token;

namespace Persistence.Services.Login
{
    public class LoginService : ILoginService
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IMapper _mapper;
        private readonly ITokenHandler _tokenHandler;

        public LoginService(ICustomerReadRepository customerReadRepository, IMapper mapper, ITokenHandler tokenHandler)
        {
            _customerReadRepository = customerReadRepository;
            _mapper = mapper;
            _tokenHandler = tokenHandler;
        }

        public async Task<LoginUserCommandResponse> LoginHandler(string email, string password)
        {
            // Retrieve the user by email
            var customer = await _customerReadRepository.GetWhere(p => p.Email == email).FirstOrDefaultAsync();
            if (customer == null)
            {
                // Handle user not found (throw an exception or return a specific result)
                return new LoginUserCommandErrorResponse()
                {
                    Message = "Kullanıcı bulunamadı."
                };
            }

            // Verify the password
            bool isPasswordValid = PasswordHasher.VerifyPassword(password, customer.Password);
            if (!isPasswordValid)
            {
                // Handle invalid password (throw an exception or return a specific result)
                return new LoginUserCommandErrorResponse()
                {
                    Message = "Şifreniz doğru değil."
                };
            }

            // If the login is successful, map the Customer to CustomerDto
            var customerDto = _mapper.Map<CustomerDto>(customer);

            TokenModel token = _tokenHandler.CreateAccessToken(5, customerDto.Email, customerDto.Name);
            return new LoginUserCommandSucceededResponse()
            {
                Token = token
            };
        }
    }
}
