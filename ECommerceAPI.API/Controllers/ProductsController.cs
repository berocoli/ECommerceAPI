using Application.DTOs;
using Application.Features.Queries.Products.GetAllProducts;
using Application.Features.Queries.Products.GetProductsById;
using Application.Features.Queries.Products.GetProductsWhere;
using Application.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// safe delete yap

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductService _productService;
        readonly private IMediator mediator;

        public ProductsController(IProductService productService, IMediator _mediator)
        {
            _productService = productService;
            mediator = _mediator;
        }
        
        [HttpGet("list")]
        public async Task<IActionResult> ListProducts()
        {
            var result = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var request = new GetProductsByIdQueryRequest { ProductId = id };
            GetProductsByIdQueryResponse result = await mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetWhere([FromQuery] string name)
        {
            var request = new GetProductsWhereQueryRequest { Name = name };
            List<GetProductsWhereQueryResponse> response = await mediator.Send(request);
            return Ok(response);
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

        [HttpGet("list(stored)")]
        public async Task<IActionResult> StoredProc()
        {
            var result = await _productService.GetAllProductsStorage();
            return Ok(result);
        }
    }
}