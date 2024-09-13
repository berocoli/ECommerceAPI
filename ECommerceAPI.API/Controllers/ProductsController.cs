using Application.Features.Commands.Products.CreateProduct;
using Application.Features.Commands.Products.DeleteProduct;
using Application.Features.Commands.Products.UpdateProduct;
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
        public async Task<IActionResult> Create(CreateProductCommandRequest request)
        {
            var result = await mediator.Send(request);
            return Ok(result);
        }

        [HttpPut("byId")]
        public async Task<IActionResult> Update(UpdateProductCommandRequest request)
        {
            var result = await mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteProductCommandRequest request)
        {
            var result = await mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("list(stored)")]
        public async Task<IActionResult> StoredGetProcedure()
        {
            var result = await _productService.GetAllProductsStorage();
            return Ok(result);
        }
    }
}