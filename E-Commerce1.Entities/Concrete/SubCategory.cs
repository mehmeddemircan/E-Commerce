using E_Commerce1.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Entities.Concrete
{
    public class SubCategory : BaseEntity
    {

        public string Name { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

       
    }
}
