using System;
using Microsoft.AspNetCore.Mvc;
using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Domain;

// safe delete yap

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
        public async Task<IActionResult> Set([FromBody] List<Product> products)
        {
            var product = products.Select(p => new Product
            {
                Name = p.Name,
                Stock = p.Stock,
                Price = p.Price
            }).ToList();

            await _productWriteRepository.AddRangeAsync(product);
            await _productWriteRepository.SaveAsync();

            return Ok(product);
        }

        [HttpPut]
        public async Task Update(string id, string name, double stock, double price)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            product.Name = name;
            product.Stock = stock;
            product.Price = price;
            await _productWriteRepository.SaveAsync();
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
            var product = await _productReadRepository.GetWhere(p => p.Name.Contains(name)).ToListAsync();
            return Ok(product);
        }
    }
}
