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
    public class BrandManager : IBrandService
    {

        IBrandRepository _brandRepository;

        public BrandManager(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository; 
        }

        public async Task<List<Brand>> GetAll()
        {
            return await _brandRepository.GetAll(); 
        }

        public Task<Brand> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Brand>> GetList(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<BrandDTO> GetOneBrandDetail(int id)
        {
            return await _brandRepository.GetOneBrandDetail(id); 
        }

        public Task<Brand> GetSingle(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<Brand> TAdd(Brand entity)
        {
            return await _brandRepository.TAdd(entity); 
        }

        public Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(int id, Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
