using System;
using Microsoft.AspNetCore.Mvc;
using Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository  = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpPost]
        public async Task Set()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Berke", Price = 1604.6, CreatedDate = DateTime.UtcNow, Stock = 1},
                new() { Id = Guid.NewGuid(), Name = "Gamze", Price = 3456.99, CreatedDate = DateTime.UtcNow, Stock = 1},
                new() { Id = Guid.NewGuid(), Name = "Ervin", Price = 243453.0, CreatedDate = DateTime.UtcNow, Stock = 1},
            });
            var count = await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var product = await _productReadRepository.GetByIdAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere([FromQuery] string name)
        {
            var products = await _productReadRepository.GetWhere(p => p.Name.Contains(name)).ToListAsync();
            return Ok(products);
        }

        [HttpGet("single")]
        public async Task<IActionResult> GetSingle([FromQuery] string name)
        {
            var product = await _productReadRepository.GetSingleAsync(p => p.Name == name);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}

