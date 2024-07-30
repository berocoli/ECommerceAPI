using System.Threading.Tasks;
using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListCustomers()
        {
            var customers = await _customerService.GetAllCustomersAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere([FromQuery] string name)
        {
            var customers = await _customerService.SearchCustomersByNameAsync(name);
            return Ok(customers);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateCustomerDto createCustomerDto)
        {
            var result = await _customerService.CreateCustomerAsync(createCustomerDto);
            if (result)
                return Ok();
            return BadRequest("Could not create the customer.");
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateCustomerDto updateCustomerDto)
        {
            var result = await _customerService.UpdateCustomerAsync(updateCustomerDto);
            if (result)
                return Ok();
            return BadRequest("Could not update the customer.");
        }

        [HttpDelete("byId")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _customerService.DeleteCustomerAsync(id);
            if (result)
                return Ok();
            return BadRequest("Could not delete the customer.");
        }
    }
}
