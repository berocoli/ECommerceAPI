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
        private readonly IUserReadRepository _userReadRepository;
        private readonly IMapper _mapper;
        private readonly ITokenHandler _tokenHandler;

        public LoginService(IUserReadRepository userReadRepository, IMapper mapper, ITokenHandler tokenHandler)
        {
            _userReadRepository = userReadRepository;
            _mapper = mapper;
            _tokenHandler = tokenHandler;
        }

        public async Task<LoginUserCommandResponse> LoginHandler(string email, string password)
        {
            // Retrieve the user by email
            var user = await _userReadRepository.GetWhere(p => p.Email == email).FirstOrDefaultAsync();
            if (user == null)
            {
                return new LoginUserCommandErrorResponse()
                {
                    Message = "Kullanıcı bulunamadı."
                };
            }

            // Verify the password
            bool isPasswordValid = PasswordHasher.VerifyPassword(password, user.Password);
            if (!isPasswordValid)
            {
                return new LoginUserCommandErrorResponse()
                {
                    Message = "Şifreniz doğru değil."
                };
            }

            // Map the user to UserDto
            var userDto = _mapper.Map<UserDto>(user);

            // Create the token
            TokenModel token = _tokenHandler.CreateAccessToken(5, userDto.Email, userDto.Name, userDto.Surname, userDto.Role); 

            return new LoginUserCommandSucceededResponse()
            {
                Token = token
            };
        }
    }
}
