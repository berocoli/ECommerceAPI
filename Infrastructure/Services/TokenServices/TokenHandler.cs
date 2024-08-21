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
        private readonly ICustomerService _customerService;

        public TokenHandler(IConfiguration configuration, ICustomerService customerService)
        {
            _configuration = configuration;
            _customerService = customerService; 
        }

        public TokenModel CreateAccessToken(int second, string email, string name)
        {
            TokenModel token = new TokenModel();

            // Retrieve the secret key from configuration (User Secrets)
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Secret"]));

            // Create signing credentials using the security key
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Set token expiration time
            token.Expiration = DateTime.UtcNow.AddSeconds(second);

            // Create JWT claims, including jti (unique token ID) and iat (issued at)
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // Unique ID for this token
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64), //
                new Claim(JwtRegisteredClaimNames.Email, email),
                new Claim(JwtRegisteredClaimNames.Name, name)
                // Issued at time
                // Add other claims as necessary, e.g., user-specific claims like roles, email, etc.
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
