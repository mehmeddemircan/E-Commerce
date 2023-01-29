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
    public class CategoryRepository : EfEntityRepositoryBase<Category, ApplicationDbContext>, ICategoryRepository
    {
        public async Task<CategoryDTO> AddCategoryDTO(CategoryDTO category)
        {
            using (var context = new ApplicationDbContext())
            {
                await context.Set<CategoryDTO>().AddAsync(category);
                await context.SaveChangesAsync();
                return category;
            }
        }

        public async Task<List<CategoryDTO>> GetCategoryDetails()
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from c in context.Categories

                             select new CategoryDTO
                             {
                                 //UserId = user.Id,
                                 //UserName = user.Name,
                                 //UserSurname = user.Surname,
                                 //UserPhone = user.PhoneNumber,
                                   Id = c.Id,
                                   Name = c.Name,
                                   CreatedTime = c.CreatedTime,
                                   SubCategories = c.SubCategories
                             };
                return await result.ToListAsync();
            }
        }
    }
}
