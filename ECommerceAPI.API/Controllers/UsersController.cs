using Application.DTOs;
using Application.Features.Commands.Users.CreateUser;
using Application.Features.Commands.Users.DeleteUser;
using Application.Features.Commands.Users.UpdateUser;
using Application.Features.Queries.Orders.GetAllOrders;
using Application.Features.Queries.Users.GetUsersById;
using Application.Features.Queries.Users.GetUsersWhere;
using Application.Services.PdfServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPdfServices _pdfService;
        private readonly IMediator mediator;


        public UserController(IPdfServices pdfServices, IMediator _mediator)
        {
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
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommandRequest request)
        {
            var result = await mediator.Send(request);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateUserCommandRequest request)
        {
            var result = await mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("byId")]
        public async Task<IActionResult> Delete(DeleteUserCommandRequest request)
        {
            var result = await mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("PDF")]
        public async Task<IActionResult> ListUsersPDF()
        {
            var result = await mediator.Send(new GetAllUsersQueryRequest());

            List<UserDto> users = result.ToList();
            // List<UserDto> users = await _userService.GetAllUsersAsync();

            byte[] pdfBytes = _pdfService.GeneratePdf(users);
            return File(pdfBytes, "application/pdf", "UsersList.pdf");
        }
    }
}