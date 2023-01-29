using E_Commerce1.Core.DataAccess;
using E_Commerce1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.DataAccess.Abstract
{
    public interface ISubCategoryRepository : IEntityRepository<SubCategory>
    {

        public List<IGrouping<int, SubCategory>> GroupByCategoryId();
    }
}
