using E_Commerce1.Entities.Common;
using E_Commerce1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Entities.DTOs
{
    public class CategoryDTO : BaseEntity
    {




        public string Name { get; set; }


        public ICollection<SubCategory> SubCategories { get; set; }


    }
}
