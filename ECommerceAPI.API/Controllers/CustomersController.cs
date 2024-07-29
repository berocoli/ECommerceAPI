using System;
using AutoMapper;
using System.Collections.Generic;
using Domain;
using Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        readonly private IMapper _mapper;

        readonly private ICustomerReadRepository _customerReadRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;

        public CustomersController(IMapper mapper, ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _mapper = mapper;

            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }
        [HttpGet("list")]
        public async Task<IActionResult> ListCustomers()
        {
            var customer =  _customerReadRepository.GetAll();
            return Ok(customer);
        }

        [HttpPost("setter")]
        public async Task<IActionResult> Set([FromForm] List<Customer> customers)
        {
            var customer = customers.Select(c => new Customer
            {
                Name = c.Name,
            }).ToList();

            await _customerWriteRepository.AddRangeAsync(customer);
            await _customerWriteRepository.SaveAsync();

            return Ok(customer);
        }

        [HttpPut("update")]
        public async Task Update(string id, string name, string email)
        {
            Customer customer = await _customerReadRepository.GetByIdAsync(id);

            customer.Name = name;
            customer.Email = email;
            await _customerWriteRepository.SaveAsync();
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
        [HttpDelete("byId")]
        public async Task<IActionResult> Delete(string id)
        {
            var customer = await _customerReadRepository.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            bool result = await _customerWriteRepository.RemoveAsync(id);
            if (!result)
            {
                return BadRequest("Could not delete the customer.");
            }

            await _customerWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
