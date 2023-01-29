using E_Commerce1.Core.DataAccess;
using E_Commerce1.Entities.Concrete;
using E_Commerce1.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.DataAccess.Abstract
{
    public interface IProductRepository : IEntityRepository<Product>
    {

        public Task<List<ProductDTO>> GetProductDetails();

        public Task<ProductDTO> GetOneProductDetail(int id);
        

        public Task<List<Product>> GetProductsByBrandId(int brandId);

        public Task<List<Product>> GetProdutsByCategoryId(int categoryId);

        public Task<List<Product>> GetProductsBySubId(int subCategoryId);
        //Markaya göre gruplama
        //Category gore gruplama
        //Altcategory göre gruplama 
    }
}
