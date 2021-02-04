using AutoMapper;
using CorporateQnA.Data.Models;
using CorporateQnA.Models;
using Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CorporateQnA.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<Category>> GetAllCategories()
        {
            var dbCategories =  await _categoryService.GetAllCategories();
            var categories = _mapper.Map<List<DbCategory>,List<Category>>(dbCategories);
            return categories;
        }

        [HttpPost]
        public async Task<ActionResult> AddCategory(Category category)
        {
            await _categoryService.AddCategory(_mapper.Map<Category, DbCategory>(category));
            return Ok();
        } 
    }
}
