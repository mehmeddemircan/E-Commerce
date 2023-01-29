using E_Commerce1.Core.DataAccess.EntityFramework;
using E_Commerce1.DataAccess.Abstract;
using E_Commerce1.DataAccess.Contexts;
using E_Commerce1.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.DataAccess.Concrete.EntityFramework
{
    public class ImageRepository : EfEntityRepositoryBase<Image, ApplicationDbContext>, IImageRepository
    {
        public async Task<List<Image>> AddMorePhotos(List<Image> Images)
        {
            using (var context = new ApplicationDbContext())
            {
                foreach (var item in Images)
                {
                    await context.Set<Image>().AddAsync(item);
                }
                await context.SaveChangesAsync();
                return Images;

            }
        }

        public async Task<List<Image>> GetPhotosByProductId(int productId)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Set<Image>().Where((i) => i.ProductId == productId).ToListAsync(); 
            }
        }
    }
}
