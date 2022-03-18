using Business.Abstract;
using Business.Concrete;
using Entities;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var category = _categoryService.GelAll();
            if (category == null) return BadRequest("hata");
            return Ok(category);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var category = _categoryService.Get(id);
            if (category == null) return BadRequest("hata");
            return Ok(category);
        }

        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            category = _categoryService.Add(category);
            if (category == null) return BadRequest("hata");
            return Ok(category);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var category = _categoryService.Get(id);
            category = _categoryService.Delete(category);
            if (category== null) return BadRequest("hata");
            return Ok(category);
        }

        [HttpPut("update")]
        public IActionResult Update(Category category)
        {
            category = _categoryService.Update(category);
            if (category == null) return BadRequest("hata");
            return Ok(category);
        }

    }
}
