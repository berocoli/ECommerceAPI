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
using Application.DTOs.Login;

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

        public async Task<TokenModel> LoginHandler(string email, string password)
        {
            // Retrieve the user by email
            var user = await _userReadRepository.GetWhere(p => p.Email == email).FirstOrDefaultAsync();
            if (user == null)
            {
                var error = "Kullanıcı bulunamadi";
                return null;
            }

            // Verify the password
            bool isPasswordValid = PasswordHasher.VerifyPassword(password, user.Password);
            if (!isPasswordValid)
            {
                var error = "Şifreniz doğru değil.";
                return null;
            }

            // Map the user to UserDto
            var userDto = _mapper.Map<UserDto>(user);

            // Create the token
            TokenModel token = _tokenHandler.CreateAccessToken(5, userDto.Id, userDto.Email, userDto.Name, userDto.Surname, userDto.Role);

            return token;
        }
    }
}
