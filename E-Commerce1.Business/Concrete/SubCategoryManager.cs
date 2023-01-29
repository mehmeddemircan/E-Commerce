using E_Commerce1.Business.Abstract;
using E_Commerce1.DataAccess.Abstract;
using E_Commerce1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {

        ISubCategoryRepository _subCategoryRepository;

        public SubCategoryManager(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }
        public async Task<List<SubCategory>> GetAll()
        {
            return await _subCategoryRepository.GetAll();
        }

      

        public Task<SubCategory> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SubCategory>> GetList(Expression<Func<SubCategory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategory> GetSingle(Expression<Func<SubCategory, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<IGrouping<int, SubCategory>> GroupByCategoryId()
        {
            return _subCategoryRepository.GroupByCategoryId(); 
        }

        public async Task<SubCategory> TAdd(SubCategory entity)
        {
            return await _subCategoryRepository.TAdd(entity);
        }

        public async Task TDelete(int id)
        {
            await _subCategoryRepository.TDelete(id);
        }

        public async Task TUpdate(int id, SubCategory entity)
        {
            await _subCategoryRepository.TUpdate(id, entity);
        }
    }
}
