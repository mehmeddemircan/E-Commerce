using E_Commerce1.Business.Abstract;
using E_Commerce1.DataAccess.Abstract;
using E_Commerce1.Entities.Concrete;
using E_Commerce1.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Business.Concrete
{
    public class ProductManager : IProductService
    {


        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository; 
        }

        public async Task<List<Product>> GetAll()
        {
           return await _productRepository.GetAll();    
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetList(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDTO> GetOneProductDetail(int id)
        {
            return await _productRepository.GetOneProductDetail(id);
        }

        public async Task<List<Product>> GetProductsBySubId(int subCategoryId)
        {
            return await _productRepository.GetProductsBySubId(subCategoryId);
        }

        public async Task<List<ProductDTO>> GetProductDetails()
        {
            return await _productRepository.GetProductDetails(); 
        }

        public async Task<List<Product>> GetProductsByBrandId(int brandId)
        {
            return await _productRepository.GetProductsByBrandId(brandId);
        }

        public async Task<List<Product>> GetProdutsByCategoryId(int categoryId)
        {
            return await _productRepository.GetProdutsByCategoryId(categoryId);
        }

        public Task<Product> GetSingle(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> TAdd(Product entity)
        {
            return await _productRepository.TAdd(entity); 
        }

        public Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(int id, Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
