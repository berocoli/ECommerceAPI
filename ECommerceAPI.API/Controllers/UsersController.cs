using Application.DTOs;
using Application.Features.Queries.Orders.GetAllOrders;
using Application.Features.Queries.Users.GetUsersById;
using Application.Features.Queries.Users.GetUsersWhere;
using Application.Services;
using Application.Services.PdfServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IPdfServices _pdfService;
        private readonly IMediator mediator;


        public UserController(IUserService userService, IPdfServices pdfServices, IMediator _mediator)
        {
            _userService = userService;
            _pdfService = pdfServices;
            mediator = _mediator;
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListUsers()
        {
            var response = await mediator.Send(new GetAllUsersQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var request = new GetUsersByIdQueryRequest { UserId = id };
            GetUsersByIdQueryResponse response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere(string name)
        {
            var request = new GetUsersWhereQueryRequest { Name = name };
            List<GetUsersWhereQueryResponse> response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
        {
            var result = await _userService.CreateUserAsync(createUserDto);
            if (result)
                return Ok();
            return BadRequest("Could not create the User.");
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserDto updateUserDto)
        {
            var result = await _userService.UpdateUserAsync(updateUserDto);
            if (result)
                return Ok();
            return BadRequest("Could not update the User.");
        }

        [HttpDelete("byId")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _userService.DeleteUserAsync(id);
            if (result)
                return Ok();
            return BadRequest("Could not delete the User.");
        }

        [HttpGet("PDF")]
        public async Task<IActionResult> ListUsersPDF()
        {
            List<UserDto> users = await _userService.GetAllUsersAsync();

            byte[] pdfBytes = _pdfService.GeneratePdf(users);
            return File(pdfBytes, "application/pdf", "UsersList.pdf");
        }
    }
}