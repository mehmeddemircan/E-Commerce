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
    public class ImageManager : IImageService
    {

        IImageRepository _imageRepository;

        public ImageManager(IImageRepository imageRepository )
        {
            _imageRepository = imageRepository; 
        }

        public async Task<List<Image>> AddMorePhotos(List<Image> Images)
        {
           return await _imageRepository.AddMorePhotos(Images);
        }

        public Task<List<Image>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Image> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Image>> GetList(Expression<Func<Image, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Image>> GetPhotosByProductId(int productId)
        {
            return await _imageRepository.GetPhotosByProductId(productId); 
        }

        public Task<Image> GetSingle(Expression<Func<Image, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<Image> TAdd(Image entity)
        {
            return await _imageRepository.TAdd(entity); 
        }

        public Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(int id, Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
