using Application.DTOs;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly IMapper _mapper;

        public CategoriesService(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository, IMapper mapper)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryDto>> GetAllCategories()
        {
            var categories = await _categoryReadRepository.GetAll().ToListAsync();
            return _mapper.Map<List<CategoryDto>>(categories);            
        }

        public async Task<List<CategoryDto>> GetProductsByCategories()
        {
            var cps = await _categoryReadRepository
                .GetAll()
                .Include(ca => ca.Products)
                .ToListAsync();
            return _mapper.Map<List<CategoryDto>>(cps);
        }

        public async Task<CategoryDto> GetProductByCategoryId(string productId)
        {
            if(!Guid.TryParse(productId, out var productGuid))
            {
                throw new FormatException();
            }
            var categories = await _categoryReadRepository.GetWhere(c => c.Id == productGuid).Include(c => c.Products).FirstOrDefaultAsync();
            return _mapper.Map<CategoryDto>(categories);
        }

        // Added Method
        public async Task<CategoryDto> GetProductsByCategoryName(string categoryName)
        {
            var category = await _categoryReadRepository.GetWhere(ca => ca.CategoryName == categoryName)
                .Include(ca => ca.Products)
                .SingleOrDefaultAsync();

            if (category == null)
            {
                return null;
            }

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<bool> CreateCategory(string categoryName)
        {
            var createCategoryDto = new CategoryDto
            {
                CategoryName = categoryName,
            };

            var category = _mapper.Map<ProductsCategory>(createCategoryDto);
            var result = await _categoryWriteRepository.AddAsync(category);
            await _categoryWriteRepository.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateCategory(string categoryName)
        {
            var updateCategoryDto = new CategoryDto
            {
                CategoryName = categoryName,
            };

            var category = _mapper.Map<ProductsCategory>(updateCategoryDto);
            var result = _categoryWriteRepository.Update(category);
            return result;

        }

        public async Task<bool> DeleteCategory(string id)
        {
            var result = await _categoryWriteRepository.RemoveAsync(id);
            return result;
        }
    }
}

