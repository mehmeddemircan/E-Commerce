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
    public class CategoriesController : ControllerBase
    {

        ICategoryService _categoryService;
  
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
      

        }

        [HttpGet("getall-category")]

        public async Task<ActionResult<List<Category>>> GetAll()
        {



            return await _categoryService.GetAll();
        }

        [HttpPost("add-category")]

        public async Task<ActionResult<Category>> AddCategory( Category category)
        {
           

            return  await _categoryService.TAdd(category);

        
           }

        [HttpGet("get-category-details")]

        public async Task<ActionResult<List<CategoryDTO>>> GetCategoryDetails()
        {
            return await _categoryService.GetCategoryDetails(); 
        }
    }
}
