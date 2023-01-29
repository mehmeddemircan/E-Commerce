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
    public class ColorRepository : EfEntityRepositoryBase<Color, ApplicationDbContext>, IColorRepository
    {
        public async Task<ProductColor> AddColorToProduct(ProductColor productColor)
        {
            using (var context = new ApplicationDbContext())
            {
                await context.Set<ProductColor>().AddAsync(productColor);
                await context.SaveChangesAsync();
                return productColor; 
            }
        }

        public async Task<List<ProductColor>> GetColorsByProductId(int productId)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Set<ProductColor>().Where(p => p.ProductId == productId).ToListAsync(); 
            }
        }
    }
}
