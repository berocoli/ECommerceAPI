using System;
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
            _customerReadRepository     = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpPost]
        public async Task Set()
        {
            await _customerWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Ervin Parlak", CreatedDate = DateTime.UtcNow},
                new() { Id = Guid.NewGuid(), Name = "Berke Ozturk", CreatedDate = DateTime.UtcNow},
                new() { Id = Guid.NewGuid(), Name = "Doga Su Turkileri", CreatedDate = DateTime.UtcNow},
                new() { Id = Guid.NewGuid(), Name = "Gamze Naz Yildirim", CreatedDate = DateTime.UtcNow},
                new() { Id = Guid.NewGuid(), Name = "Atakan Yildirim", CreatedDate = DateTime.UtcNow},
            });
            var count = await _customerWriteRepository.SaveAsync();
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
        [HttpGet("single")]
        public async Task<IActionResult> GetSingleAsync([FromQuery] string name)
        {
            var customer = await _customerReadRepository.GetSingleAsync(p => p.Name.Contains(name));
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }
    }
}

