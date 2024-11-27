using System;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoriesService _categoryService;
        public CategoryController(ICategoriesService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("product")]
        public async Task<IActionResult> GetCategories()
        {
            var result = await _categoryService.GetProductsByCategories();
            return Ok(result);
        }

        [HttpGet("names")]
        public async Task<IActionResult> GetNames()
        {
            var result = await _categoryService.GetAllCategories();
            return Ok(result);
        }
        //Added Endpoint
        [HttpGet("byName{name}")]
        public async Task<IActionResult> GetCategoriesByName(string name)
        {
            var result = await _categoryService.GetProductsByCategoryName(name);
            return Ok(result);
        }

        [HttpPost("byName{name}")]
        public async Task<IActionResult> CreateCategory(string name)
        {
            var result = await _categoryService.CreateCategory(name);
            return Ok(result);
        }

        [HttpPut("byName")]
        public async Task<IActionResult> UpdateCategory(string name)
        {
            if(name == null)
            {
                throw new FormatException("Name is null. Try again.");
            }
            var result = await _categoryService.UpdateCategory(name);
            return Ok(result);
        }

        [HttpDelete("byId{id}")]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            var result = await _categoryService.DeleteCategory(id);
            return Ok(result);
        }
    }
}
