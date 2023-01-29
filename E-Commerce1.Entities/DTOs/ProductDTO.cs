using E_Commerce1.Entities.Common;
using E_Commerce1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Entities.DTOs
{
    public class ProductDTO : BaseEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public int BrandId { get; set; }

        public virtual Brand brand { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<ProductSize> ProductSizes { get; set; }

        public virtual ICollection<ProductColor> ProductColors { get; set; }

        public int ModelId { get; set; }

        public virtual Model Model { get; set; }
    }
}
