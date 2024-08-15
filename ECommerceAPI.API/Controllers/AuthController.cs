using System;
using Application.Services;
using Application.Services.TokenServices;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly ITokenService _tokenService;
        public AuthController(ILoginService loginService, ITokenService tokenService)
        {
            _loginService = loginService;
            _tokenService = tokenService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginCustomer(string Email, string Password)
        {
            // Use the login service to handle the login process
            var userLogged = await _loginService.LoginHandler(Email, Password);

            if (userLogged == null)
            {
                // Login failed, return unauthorized response
                return Unauthorized("Invalid email or password.");
            }

            var token = _tokenService.TokenGenerator(Email);
            return Ok(new { Token = token });
            // Login successful, return the user data
            // return Ok(userLogged);
        }
    }
}

