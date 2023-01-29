using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Entities.Concrete
{
    public class ProductColor
    {

        public int ProductId { get; set; }

        public virtual Product? Product { get; set; }

        public int ColorId { get; set; }

        public virtual Color? Color { get; set; }
    }
}
