using Application.DTOs;
using Application.Services;
using Application.Services.PdfServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IPdfServices _pdfService;


        public CustomersController(ICustomerService customerService, IPdfServices pdfServices)
        {
            _customerService = customerService;
            _pdfService = pdfServices;
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListCustomers()
        {
            var result = await _customerService.GetAllCustomersAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _customerService.GetCustomerByIdAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere([FromQuery] string name)
        {
            var result = await _customerService.SearchCustomersByNameAsync(name);
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerDto createCustomerDto)
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

        [HttpGet("PDF")]
        public async Task<IActionResult> ListCustomersPDF()
        {
            List<CustomerDto> customers = await _customerService.GetAllCustomersAsync();

            byte[] pdfBytes = _pdfService.GeneratePdf(customers);
            return File(pdfBytes, "application/pdf", "CustomersList.pdf");
        }
    }
}
