using System;
using Microsoft.AspNetCore.Mvc;
using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Domain;
using Application.Services;
using Application.DTOs;
using Persistance.Repositories;

// safe delete yap

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet]
        public async Task<IActionResult> ListProducts()
        {
            var result = await _productService.GetAllProductsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _productService.GetProductByIdAsync(id);
            if (result == null)
                return null;
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere([FromQuery] string name)
        {
            var result = await _productService.SearchProductsByNameAsync(name);
            if (result == null)
                return null;
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto createProductDto)
        {
            var result = await _productService.CreateProductsAsync(createProductDto);
            if (result)
                return Ok();
            return BadRequest("Could not create the customer");
        }

        [HttpPut("byId")]
        public async Task<IActionResult> Update(UpdateProductDto updateProductDto)
        {
            var result = await _productService.UpdateProductsAsync(updateProductDto);
            if(result)
                return Ok();
            return BadRequest("Could not update the product");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _productService.DeleteProductAsync(id);
            if(result)
               return Ok();
            return BadRequest("Could not delete the product");
        }
    }
}
