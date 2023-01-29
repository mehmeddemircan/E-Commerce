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
    public class ColorManager : IColorService
    {

        IColorRepository _colorRepository;

        public ColorManager(IColorRepository colorRepository )
        {
            _colorRepository = colorRepository;
        }

        public async Task<ProductColor> AddColorToProduct(ProductColor productColor)
        {
            return await _colorRepository.AddColorToProduct(productColor);
        }

        public async Task<List<Color>> GetAll()
        {
            return await _colorRepository.GetAll();
        }

        public Task<Color> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductColor>> GetColorsByProductId(int productId)
        {
            return await _colorRepository.GetColorsByProductId(productId);  
        }

        public Task<List<Color>> GetList(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Color> GetSingle(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<Color> TAdd(Color entity)
        {
            return await _colorRepository.TAdd(entity); 
        }

        public Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(int id, Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
