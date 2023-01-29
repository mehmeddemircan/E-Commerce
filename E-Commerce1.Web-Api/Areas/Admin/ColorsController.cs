using E_Commerce1.Business.Abstract;
using E_Commerce1.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce1.Web_Api.Areas.Admin
{
    [Area("Admin")]
    [Route("api/admin/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {

        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("get-all-color")]

        public async Task<ActionResult<List<Color>>> GetAllColor()
        {
            return await _colorService.GetAll(); 
        }

        [HttpPost("add-color")]

        public async Task<ActionResult<Color>> AddColor(Color color)
        {
            return await _colorService.TAdd(color); 
        }
        [HttpPost("add-color-to-product")]

        public async Task<ActionResult<ProductColor>> AddColorToProduct(ProductColor productColor)
        {
            return await _colorService.AddColorToProduct(productColor);
        }

        [HttpGet("get-color-product")]

        public async Task<ActionResult<List<ProductColor>>> GetProductColors(int productId)
        {

            return await _colorService.GetColorsByProductId(productId);
        }

    }
}
