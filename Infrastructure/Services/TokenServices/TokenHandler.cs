using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.DTOs.Token;
using Application.Services;
using Application.Services.TokenServices;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Services.TokenServices
{
    public class TokenHandler : ITokenHandler
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public TokenHandler(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }

        public TokenModel CreateAccessToken(int minutes, string id, string email, string name, string surname, bool role)
        {
            TokenModel token = new TokenModel();

            // Retrieve the secret key from configuration (User Secrets)
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Secret"]));

            // Create signing credentials using the security key
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Set token expiration time
            token.Expiration = DateTime.UtcNow.AddMinutes(minutes);

            // Create JWT claims
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // Unique ID for this token
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64), // Issued at time
                new Claim(JwtRegisteredClaimNames.Sub, id, ClaimValueTypes.String),
                new Claim(JwtRegisteredClaimNames.Email, email, ClaimValueTypes.Email), 
                new Claim(JwtRegisteredClaimNames.Name, name, ClaimValueTypes.String),
                new Claim(JwtRegisteredClaimNames.FamilyName, surname, ClaimValueTypes.String),
                
                new Claim("role", role.ToString())
            };
                       
            // Create the JWT security token
            JwtSecurityToken securityToken = new JwtSecurityToken(
                audience: _configuration["JwtSettings:Audience"],
                issuer: _configuration["JwtSettings:Issuer"],
                claims: claims,
                expires: token.Expiration,
                notBefore: DateTime.UtcNow,
                signingCredentials: signingCredentials
            );

            // Generate the JWT token string
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            token.Access = jwtSecurityTokenHandler.WriteToken(securityToken);

            return token;
        }
    }
}
