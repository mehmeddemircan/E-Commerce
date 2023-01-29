using E_Commerce1.Business.Abstract;
using E_Commerce1.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce1.Web_Api.Areas.Admin
{
    [Area("Admin")]
    [Route("api/admin/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {

        IImageService _imageService;

        public ImagesController(IImageService imageService )
        {
            _imageService = imageService; 
        }


        [HttpGet("get-by-productId")]

        public async Task<ActionResult<List<Image>>> GetPhotosByProductId(int productId)
        {
            return await _imageService.GetPhotosByProductId(productId); 
        }

        [HttpPost("add-image")]

        public async Task<ActionResult<Image>> AddPhoto (Image image)
        {
            return await _imageService.TAdd(image); 
        }

        // çoklu foto ekleme 

        [HttpPost("add-more-image")]

        public async Task<ActionResult<List<Image>>> AddMorePhotos(List<Image> Images)
        {
            return await _imageService.AddMorePhotos(Images);
        }
    }
}
