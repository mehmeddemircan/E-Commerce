using E_Commerce1.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<SubCategory>? SubCategories { get; set; }

      
    }
}
