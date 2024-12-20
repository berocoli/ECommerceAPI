using Application.DTOs;
using Application.DTOs.Product.Details;
using Application.Exceptions;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain.Entities.BaseEntity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductDetailReadRepository _productDetailReadRepository;
        private readonly IProductDetailWriteRepository _productDetailWriteRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IProductDetailReadRepository productDetailReadRepository, IProductDetailWriteRepository productDetailWriteRepository, IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _productDetailReadRepository = productDetailReadRepository;
            _productDetailWriteRepository = productDetailWriteRepository;
            _mapper = mapper;
        }
                
        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            var product = await _productReadRepository.GetAll().Include(p => p.Category).ToListAsync();
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

        public async Task<List<RandomizedProductDto>> Randomizer()
        {
            var products = await _productReadRepository.Randomizer();

            if (products == null || !products.Any())
            {
                return null;
            }

            return _mapper.Map<List<RandomizedProductDto>>(products);
        }

        public async Task<bool> CreateProductsAsync(string categoryId, string name, double price, double stock, string description, string imageUrl)
        {
            var doesExist = await _productReadRepository.GetSingleAsync(p => p.ImageUrl == imageUrl && p.Name == name);

            if(doesExist != null)
            {
                return false;
            }

            var createProductDto = new CreateProductDto
            {
                CategoryId = categoryId,
                Name = name,
                Price = price,
                Stock = stock,
                Description = description,
                ImageUrl = imageUrl
            };
            var product = _mapper.Map<Product>(createProductDto);
            var result = await _productWriteRepository.AddAsync(product);
            await _productWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> InsertRange(List<CreateProductDto> products)
        {
            if(products == null)
            {
                return false;
            }
            var createProductEntities = _mapper.Map<List<Product>>(products);
            var result = await _productWriteRepository.AddRangeAsync(createProductEntities);
            await _productWriteRepository.SaveAsync();
            return result;
        }


        public async Task<bool> UpdateProductsAsync(string id, string categoryId, string name, double price, double stock, string description, string imageUrl)
        {
            var product = await _productReadRepository.GetByIdAsync(id);
            if (product == null)
                return false;
            var updateProductDto = new UpdateProductDto
            {
                CategoryId = categoryId,
                Name = name,
                Price = price,
                Stock = stock,
                Description = description,
                ImageUrl = imageUrl                              
            };
            _mapper.Map(updateProductDto, product);
            var result = _productWriteRepository.Update(product);
            await _productWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateProductStock(string id, double newStock)
        {
            if (!Guid.TryParse(id, out var productGuid))
                throw new FormatException("Wrong Guid format.");
            var product = await _productReadRepository.GetByIdAsync(id);
            if(product == null)
            {
                throw new GetRequestFailedException("Product does not exist.");
            }
            if (newStock < 0)
            {
                throw new FailException("Wrong product quantity.");
            }

            var pDto = new UpdateProductDto
            {
                CategoryId = product.CategoryId.ToString(),
                Name = product.Name,
                Price = product.Price,
                Stock = newStock,
                Description = product.Description,
                ImageUrl = product.ImageUrl
            };

            _mapper.Map(pDto, product);
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

        public async Task<ProductDto> GetProductAsJsonFunc(string id)
        {
            var products = await _productReadRepository.GetProductAsJsonAsync(id);

            var result = _mapper.Map<ProductDto>(products);

            return result;  
        }

        public async Task<ProductDetailDto> GetProductDetails(string id)
        {
            if (!Guid.TryParse(id, out var productGuid))
                throw new FormatException("Wrong Id Format.");

            var details = await _productDetailReadRepository.GetByIdAsync(id);

            return _mapper.Map<ProductDetailDto>(details);         
        }

        public async Task<bool> CreateProductDetailsAsync(string id, string detail1, string detail2, string detail3)
        {
            if (!Guid.TryParse(id, out var productGuid))
                throw new FormatException("Wrong Id format.");

            var doesExist = await _productDetailReadRepository.GetByIdAsync(id);
            Console.WriteLine($"DoesExist Value: {doesExist}");
            if (doesExist != null)
            {
                throw new FailException($"Product with Id {id} has details set already!");
            }

            var dto = new ProductDetailDto
            {
                ProductId = id,
                ProductDetail1 = detail1,
                ProductDetail2 = detail2,
                ProductDetail3 = detail3
            };

            var detail = _mapper.Map<ProductDetail>(dto);
            var result = await _productDetailWriteRepository.AddAsync(detail);
            await _productDetailWriteRepository.SaveAsync();

            return result;
        }

        public async Task<bool> UpdateProductDetails(string id, string detail1, string detail2, string detail3)
        {
            if (!Guid.TryParse(id, out var productGuid))
                throw new FormatException("Wrong Id format.");

            var doesExist = await _productDetailReadRepository.GetByIdAsync(id);
            if(doesExist == null)
            {
                var product = await _productReadRepository.GetByIdAsync(id) ??
                    throw new FailException("Product does not exist!");

                var cDto = new ProductDetailDto
                {
                    ProductId = id,
                    ProductDetail1 = detail1,
                    ProductDetail2 = detail2,
                    ProductDetail3 = detail3
                };
                var createProduct = _mapper.Map<ProductDetail>(cDto);
                var createResult = await _productDetailWriteRepository.AddAsync(createProduct);
                await _productDetailWriteRepository.SaveAsync();
                return createResult;
            }

            doesExist.ProductDetail1 = detail1;
            doesExist.ProductDetail2 = detail2;
            doesExist.ProductDetail3 = detail3;

            var result = _productDetailWriteRepository.Update(doesExist);
            await _productDetailWriteRepository.SaveAsync();

            return result;
        }
    }
}
