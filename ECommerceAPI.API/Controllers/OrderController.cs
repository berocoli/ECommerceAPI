using Microsoft.AspNetCore.Mvc;
using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;

        public OrderController(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Set([FromBody] List<Order> orders)
        {
            var order = orders.Select(o => new Order
            {
                Address = o.Address,
                Description = o.Description,
                Status = o.Status,
            }).ToList();

            await _orderWriteRepository.AddRangeAsync(order);
            await _orderWriteRepository.SaveAsync();

            return Ok(order);
        }

        [HttpPut]
        public async Task Update(string id, string address)
        {
            Order order = await _orderReadRepository.GetByIdAsync(id);
            order.Address = address;
            await _orderWriteRepository.SaveAsync();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var order = await _orderReadRepository.GetByIdAsync(id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere([FromBody] string address)
        {
            var order = await _orderReadRepository.GetWhere(p => p.Address.Contains(address)).ToListAsync();
            if (order == null)
                return NotFound();
            return Ok(order);
        }
    }
}
/*
 * 
 *      [HttpPost]
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

        [HttpPut]
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
        [HttpDelete("{id}")]
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
 */
