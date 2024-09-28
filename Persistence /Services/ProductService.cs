using Application.DTOs;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        private readonly IMapper _mapper;

        public ProductService(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _mapper = mapper;
        }
                
        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            var product = await _productReadRepository.GetAll().ToListAsync();
            return _mapper.Map<List<ProductDto>>(product);
        }

        public async Task<ProductDto> GetProductByIdAsync(string id)
        {
            var product = await _productReadRepository.GetByIdAsync(id);
            if (product == null)
                return null;
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<List<ProductDto>> SearchProductsByNameAsync(string name)
        {
            var product = await _productReadRepository.GetWhere(p => p.Name.Contains(name)).ToListAsync();
            if (product == null)
                return null;
            return _mapper.Map<List<ProductDto>>(product);
        }

        public async Task<bool> CreateProductsAsync(string name, double price, double stock, string description)
        {
            var createProductDto = new CreateProductDto
            {
                Name = name,
                Price = price,
                Stock = stock,
                Description = description,
            };
            var product = _mapper.Map<Product>(createProductDto);
            var result = await _productWriteRepository.AddAsync(product);
            await _productWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateProductsAsync(string id, string name, double price, double stock, string description)
        {
            var product = await _productReadRepository.GetByIdAsync(id);
            if (product == null)
                return false;
            var updateProductDto = new UpdateProductDto
            {
                Id = id,
                Name = name,
                Price = price,
                Stock = stock,
                Description = description
            };
            _mapper.Map(updateProductDto, product);
            var result = _productWriteRepository.Update(product);
            await _productWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteProductAsync(string id)
        {
            var result = await _productWriteRepository.RemoveAsync(id);
            await _productWriteRepository.SaveAsync();
            return result;
        }

        public async Task<List<ProductDto>> GetAllProductsStorage()
        {
            var products = await _productReadRepository.GetFromStoredProcedureAsync();

            // Map entities to DTOs
            var productDtos = _mapper.Map<List<ProductDto>>(products);

            // Return DTOs for the client
            return productDtos;
        }
    }
}