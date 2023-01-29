using E_Commerce1.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Entities.Concrete
{
    public class Size : BaseEntity
    {

        public string Name { get; set; }

        public ICollection<ProductSize>? ProductSizes { get; set; }
    }
}
