using Application.DTOs;
using Application.Services;
using Application.Services.PdfServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IPdfServices _pdfService;


        public UserController(IUserService userService, IPdfServices pdfServices)
        {
            _userService = userService;
            _pdfService = pdfServices;
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListUsers()
        {
            var result = await _userService.GetAllUsersAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _userService.GetUserByIdAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere([FromQuery] string name)
        {
            var result = await _userService.SearchUsersByNameAsync(name);
            return Ok(result);
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
