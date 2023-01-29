using E_Commerce1.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Entities.Concrete
{
    public class Image : BaseEntity
    {

        public string Url { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
    }
}
