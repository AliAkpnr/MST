using Business.Abstract;
using Business.Concrete;
using Entities;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();
            if (products == null) return BadRequest("hata");
            return Ok(products);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var product = _productService.Get(id);
            if (product == null) return BadRequest("hata");
            return Ok(product);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            product = _productService.Add(product);
            if (product == null) return BadRequest("hata");
            return Ok(product);
        }

        [HttpGet("getallbycategoryid")]
        public IActionResult GetAllByCategoryId(int categoryId)
        {
            var products = _productService.GetAllByCategoryId(categoryId);
            if(products == null) return BadRequest("hata");
            return Ok(products);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var product = _productService.Get(id);
            product = _productService.Delete(product);
            if (product == null) return BadRequest("hata");
            return Ok(product);
        }

        [HttpPut("update")]
        public IActionResult Update(Product product)
        {
            product = _productService.Update(product);
            if (product == null) return BadRequest("hata");
            return Ok(product);
        }

    }
}
