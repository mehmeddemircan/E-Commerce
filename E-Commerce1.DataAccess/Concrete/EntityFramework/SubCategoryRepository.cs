using E_Commerce1.Core.DataAccess.EntityFramework;
using E_Commerce1.DataAccess.Abstract;
using E_Commerce1.DataAccess.Contexts;
using E_Commerce1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.DataAccess.Concrete.EntityFramework
{
    public class SubCategoryRepository : EfEntityRepositoryBase<SubCategory, ApplicationDbContext>, ISubCategoryRepository
    {
        public List<IGrouping<int, SubCategory>> GroupByCategoryId()
        {
            using (var context = new ApplicationDbContext())
            {


                return context.Set<SubCategory>().AsEnumerable()
    .GroupBy(subcategory => subcategory.CategoryId)
    .OrderBy(newGroup => newGroup.Key)
    .Select(newGroup => newGroup).ToList();


            }
        }
    }
}
