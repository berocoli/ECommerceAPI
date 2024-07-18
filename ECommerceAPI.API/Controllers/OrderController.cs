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

        readonly private ICustomerWriteRepository _customerWriteRepository;

        public OrderController(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpPost]
        public async Task Get()
        {
            var customerId = Guid.NewGuid();
            await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "Berke"});

            await _orderWriteRepository.AddAsync(new() { Description = "zontir", Address = "Kecioren", Status = "active", CustomerId = customerId });
            await _orderWriteRepository.AddAsync(new() { Description = "tontir", Address = "Akyurt", Status = "deactive", CustomerId = customerId});
            await _orderWriteRepository.SaveAsync();
        } 

        [HttpGet("update")]
        public async Task Update()
        {
            Order order = await _orderReadRepository.GetByIdAsync("3eaf492f-21ba-4571-86f0-59abac96fe68");
            order.Address = "Artvin";
            await _orderWriteRepository.SaveAsync();

        }
        /* 
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var order = await _orderReadRepository.GetByIdAsync(id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere([FromQuery] string address)
        {
            var order = await _orderReadRepository.GetWhere(p => p.Address.Contains(address)).ToListAsync();
            if (order == null)
                return NotFound();
            return Ok(order); 
        }

        [HttpGet("single")]
        public async Task<IActionResult> GetSingle([FromQuery] string address)
        {
            var order = await _orderReadRepository.GetSingleAsync(p => p.Address.Contains(address));
            if (order == null)
                return NotFound();
            return Ok(order);
        } */
    }
}

