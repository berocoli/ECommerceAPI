using System;
using Microsoft.AspNetCore.Mvc;
using Application.Repositories;

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

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Berke", Price = 1604.6, CreatedDate = DateTime.UtcNow, Stock = 1},
                new() { Id = Guid.NewGuid(), Name = "Gamze", Price = 3456.99, CreatedDate = DateTime.UtcNow, Stock = 1},
                new() { Id = Guid.NewGuid(), Name = "Ervin", Price = 243453.0, CreatedDate = DateTime.UtcNow, Stock = 1},
            });
            var count = await _productWriteRepository.SaveAsync();
        }
        // [HttpGet("id")]
        // public async Task Get()
        // {
        //    
        // }
    }
}

