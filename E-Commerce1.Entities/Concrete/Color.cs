using E_Commerce1.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Entities.Concrete
{   

    //many to many relationship
    public class Color : BaseEntity
    {

        public string Name { get; set; }

        public string HexaCode { get; set; }

        public string ThumbNailImage { get; set; }

        public  ICollection<ProductColor>? ProductColors { get; set; }
    }

}
