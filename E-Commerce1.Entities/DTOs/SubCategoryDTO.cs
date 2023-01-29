using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Entities.DTOs
{
    public class SubCategoryDTO
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }
    }
}
