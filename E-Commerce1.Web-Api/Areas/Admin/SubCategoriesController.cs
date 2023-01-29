using AutoMapper;
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
    public class SubCategoriesController : ControllerBase
    {


        ISubCategoryService _subCategoryService;
    
        public SubCategoriesController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        
        }

        [HttpGet("get-all")]

        public async Task<List<SubCategory>> GetAllSubCategory()
        {
          

            return await _subCategoryService.GetAll();
        }
        [HttpPost("add-category")]

        public async Task<ActionResult<SubCategory>> AddSubCategory(SubCategory subCategory)
        {

         

            return await _subCategoryService.TAdd(subCategory);
        }

        [HttpGet("group-subcategories")]

        public List<IGrouping<int, SubCategory>> GroupSubCategoriesByCategoryId()
        {
            return _subCategoryService.GroupByCategoryId(); 
        }

    }
}
