using Microsoft.AspNetCore.Mvc;
using Application.Repositories;
using Microsoft.EntityFrameworkCore;

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
            _orderReadRepository    = orderReadRepository;
            _orderWriteRepository   = orderWriteRepository;
        }

        [HttpPost]
        public async Task Set()
        {
            await _orderWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), Address = "Şehit Cevdet Özdemir Mah.", Description = "Vantilatör", Status = "Aktif",
                    CreatedDate = DateTime.UtcNow, Customer = new()},
            });
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
        }
    }
}

