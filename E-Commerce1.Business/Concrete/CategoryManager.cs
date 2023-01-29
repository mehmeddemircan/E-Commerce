using E_Commerce1.Business.Abstract;
using E_Commerce1.DataAccess.Abstract;
using E_Commerce1.Entities.Concrete;
using E_Commerce1.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public async Task<Category> TAdd(Category entity)
        {
            return await _categoryRepository.TAdd(entity);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _categoryRepository.GetAll();
        }

        public Task<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetList(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetSingle(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task TDelete(int id)
        {
            await _categoryRepository.TDelete(id);
        }

        public async Task TUpdate(int id, Category entity)
        {
            await _categoryRepository.TUpdate(id, entity);
        }

        public async Task<CategoryDTO> AddCategoryDTO(CategoryDTO category)
        {
            return await _categoryRepository.AddCategoryDTO(category); 
        }

        public async Task<List<CategoryDTO>> GetCategoryDetails()
        {
            return await _categoryRepository.GetCategoryDetails(); 
        }
    }
}
