using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoginService _loginService;
        
        public AuthController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginUser(string Email, string Password)
        {
            // Use the login service to handle the login process
            var userLogged = await _loginService.LoginHandler(Email, Password);
            if(userLogged == null)
            {
                return Unauthorized("Oturum açma işlemi tamamlanamamıştır. E-Posta hesabınızı veya şifrenizi kontrol edin.");
            }
            return Ok(userLogged);
        }
    }
}

          




