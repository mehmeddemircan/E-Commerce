using E_Commerce1.Business.Abstract;
using E_Commerce1.Entities.Concrete;
using E_Commerce1.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce1.Web_Api.Areas.Admin
{
    [Area("Admin")]
    [Route("api/admin/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet("get-all")]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            return await _productService.GetAll(); 
        }

        [HttpPost("add-product")]

        public async Task<ActionResult<Product>> AddProduct(Product product)
        {
            return await _productService.TAdd(product); 
        }

        [HttpGet("get-one-product-detail")]

        public async Task<ActionResult<ProductDTO>> GetOneProductDetail(int id)
        {
            return await _productService.GetOneProductDetail(id);
        }

        [HttpGet("get-product-details")]

        public async Task<ActionResult<List<ProductDTO>>> GetProductDetails()
        {
            return await _productService.GetProductDetails();
        }


        [HttpGet("get-by-subcategoryId")]

        public async Task<ActionResult<List<Product>>> GetProductsBySubId(int subcategoryId)
        {
            return await _productService.GetProductsBySubId(subcategoryId);
        }

        [HttpGet("get-by-categoryId")]

        public async Task<ActionResult<List<Product>>> GetProductsByCategoryId(int categoryId)
        {
            return await _productService.GetProdutsByCategoryId(categoryId); 
        }

        [HttpGet("get-by-brandId")]

        public async Task<ActionResult<List<Product>>> GetProductsByBrandId(int brandId)
        {
            return await _productService.GetProductsByBrandId(brandId); 
        }
    }
}
