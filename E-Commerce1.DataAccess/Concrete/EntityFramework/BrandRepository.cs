using E_Commerce1.Core.DataAccess.EntityFramework;
using E_Commerce1.DataAccess.Abstract;
using E_Commerce1.DataAccess.Contexts;
using E_Commerce1.Entities.Concrete;
using E_Commerce1.Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.DataAccess.Concrete.EntityFramework
{
    public class BrandRepository : EfEntityRepositoryBase<Brand, ApplicationDbContext>, IBrandRepository
    {
        public async Task<BrandDTO> GetOneBrandDetail(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from b in context.Brands where b.Id == id
                             select new BrandDTO
                             {
                                 Id = b.Id,
                                 Name = b.Name,
                                 Products = b.Products
                                 //Products = (from p in context.Products select new Product
                                 //{
                                 //    Id = p.Id,
                                 //    BrandId = p.BrandId,
                                 //}).ToList() 
                             };

                return await result.FirstOrDefaultAsync(); 
            }
        }
    }
}
