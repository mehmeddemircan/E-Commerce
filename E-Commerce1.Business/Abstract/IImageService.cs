using E_Commerce1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Business.Abstract
{
    public interface IImageService : IGenericService<Image>
    {


        public Task<List<Image>> GetPhotosByProductId(int productId);

        public Task<List<Image>> AddMorePhotos(List<Image> Images);

    }
}
