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
    public class ProductRepository : EfEntityRepositoryBase<Product, ApplicationDbContext>, IProductRepository
    {
        public async Task<ProductDTO> GetOneProductDetail(int id)
        {
            using (var context = new ApplicationDbContext())
            {

                var result = from p in context.Products
                             where p.Id == id
                             select new ProductDTO
                             {
                                 Id = p.Id,
                                 Name = p.Name,
                                 Description = p.Description,
                                 BrandId = p.BrandId,
                                 brand = p.Brand,
                                 Category = p.Category,
                                 SubCategory = p.SubCategory,
                                 ProductSizes = (
                            from ps in context.ProductSizes
                            where ps.ProductId == id 
                            select new ProductSize
                            {
                               ProductId = ps.ProductId,
                               SizeId = ps.SizeId,
                               Size = ps.Size 
                            }
                        ).ToList(),
                                 ProductColors = (
                                 from pc in context.ProductColors where pc.ProductId == id
                                 select new ProductColor
                                 {
                                     ProductId = pc.ProductId,
                                     ColorId = pc.ColorId,
                                     Color = pc.Color
                                 }
                                 ).ToList()
                             };

                    return await  result.FirstOrDefaultAsync(); 
            }
        }

      

        public  async Task<List<ProductDTO>> GetProductDetails()
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from p in context.Products
                             select new ProductDTO
                             {
                                 Id = p.Id,
                                 Name = p.Name,
                                 Description = p.Description,
                                 BrandId = p.BrandId,
                                 brand = p.Brand,
                                 Category = p.Category,
                                 SubCategory = p.SubCategory,
                                 Images = p.Images,
                                 ProductSizes = p.ProductSizes,


                             };
                return await  result.ToListAsync(); 
            }
        }
        public  async Task<List<Product>> GetProductsBySubId(int subCategoryId)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Set<Product>().Where((p) => p.SubCategoryId == subCategoryId).ToListAsync();
            }
        }
        public async Task<List<Product>> GetProductsByBrandId(int brandId)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Set<Product>().Where((p) => p.BrandId == brandId).ToListAsync();
            }
        }

        public async Task<List<Product>> GetProdutsByCategoryId(int categoryId)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Set<Product>().Where((p) => p.CategoryId == categoryId).ToListAsync();
            }
        }
    }
}
