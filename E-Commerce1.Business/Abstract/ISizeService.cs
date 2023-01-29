using E_Commerce1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Business.Abstract
{
    public interface ISizeService : IGenericService<Size>
    {
        public Task<List<ProductSize>> GetSizeByProductId(int productId);

        public Task<ProductSize> AddProductSize(ProductSize productSize); 
    }
}
