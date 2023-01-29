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
    public class SizeRepository : EfEntityRepositoryBase<Size, ApplicationDbContext>, ISizeRepository
    {
        public async Task<ProductSize> AddProductSize(ProductSize productSize)
        {
            using (var context = new ApplicationDbContext())
            {
                await context.Set<ProductSize>().AddAsync(productSize);
                await context.SaveChangesAsync();
                return productSize;
            }
        }

        public async Task<List<ProductSize>> GetSizesByProductId(int productId)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Set<ProductSize>().Where((s) => s.ProductId == productId).ToListAsync(); 
            }
        }
    }
}
