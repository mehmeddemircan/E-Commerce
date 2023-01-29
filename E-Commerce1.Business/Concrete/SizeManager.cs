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
    public class SizeManager : ISizeService
    {

        ISizeRepository _sizeRepository;

        public SizeManager(ISizeRepository sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }

        public async Task<ProductSize> AddProductSize(ProductSize productSize)
        {
            return await _sizeRepository.AddProductSize(productSize); 
        }

        public Task<List<Size>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Size> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Size>> GetList(Expression<Func<Size, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Size> GetSingle(Expression<Func<Size, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductSize>> GetSizeByProductId(int productId)
        {
            return await _sizeRepository.GetSizesByProductId(productId); 
        }

        public async Task<Size> TAdd(Size entity)
        {
            return await _sizeRepository.TAdd(entity); 
        }

        public Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(int id, Size entity)
        {
            throw new NotImplementedException();
        }
    }
}
