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
    public class BrandsController : ControllerBase
    {

        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService  = brandService;
        }

        [HttpGet("get-all")]

        public async Task<List<Brand>> GetAllBrand()
        {


            return await _brandService.GetAll();
        }
        [HttpPost("add-brand")]

        public async Task<ActionResult<Brand>> AddBrand(Brand subCategory)
        {



            return await _brandService.TAdd(subCategory);
        }


        [HttpGet("get-one-brand-details")]

        public async Task<ActionResult<BrandDTO>> GetOneBrandDetail(int id)
        {
            return await _brandService.GetOneBrandDetail(id); 
        }



    }
}
