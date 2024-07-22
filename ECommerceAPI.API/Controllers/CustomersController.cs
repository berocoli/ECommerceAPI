using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        readonly private ICustomerReadRepository _customerReadRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;

        public CustomersController(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Set([FromBody] List<Customer> customers)
        {
            var customer = customers.Select(c => new Customer
            {
                Name = c.Name,
            }).ToList();

            await _customerWriteRepository.AddRangeAsync(customer);
            await _customerWriteRepository.SaveAsync();

            return Ok(customer);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var customer = await _customerReadRepository.GetByIdAsync(id);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }
        [HttpGet("search")]
        public async Task<IActionResult> GetWhere([FromQuery] string name)
        {
            var customer = await _customerReadRepository.GetWhere(p => p.Name.Contains(name)).ToListAsync();
            return Ok(customer);
        }
    }
}
