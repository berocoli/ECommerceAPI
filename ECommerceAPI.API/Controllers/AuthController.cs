using Application.Features.LoginCustomer;
using Application.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginUser(LoginUserCommandRequest loginCommandReq)
        {
            LoginUserCommandResponse response= await _mediator.Send(loginCommandReq);
            return Ok(response);
        }
    }
}