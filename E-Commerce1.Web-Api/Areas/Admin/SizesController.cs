using E_Commerce1.Business.Abstract;
using E_Commerce1.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce1.Web_Api.Areas.Admin
{
    [Area("Admin")]
    [Route("api/admin/[controller]")]
    [ApiController]
    public class SizesController : ControllerBase
    {
        ISizeService _sizeService;

        public SizesController(ISizeService sizeService)
        {
            _sizeService = sizeService; 
        }

        [HttpGet("get-size-by-product-id")]
         
        public async Task<ActionResult<List<ProductSize>>> GetAllSize(int productId)
        {
            return await _sizeService.GetSizeByProductId(productId); 
        }


        [HttpPost("add-size")]

        public async Task<ActionResult<Size>> AddSize(Size size)
        {
            return await _sizeService.TAdd(size); 
        }

        [HttpPost("add-size-to-product")]

        public async Task<ActionResult<ProductSize>> AddProductSize(ProductSize productSize)
        {
            return await _sizeService.AddProductSize(productSize); 
        }
    
    }
}
