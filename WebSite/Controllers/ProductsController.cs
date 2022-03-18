using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
           
            var products = _productService.GetAll();
            ViewBag.categories = _categoryService.GelAll();

            return View(products);
        }


        public IActionResult Add(int productId=0)
        {
            var product = new Product();
            if (productId>0)
            {
                product = _productService.Get(productId);
            }
            
            var categories = _categoryService.GelAll();
            var list = new List<SelectListItem>();
            foreach (var category in categories)
            {
                var item = new SelectListItem();
                item.Value = category.Id.ToString();
                item.Text = category.Name;
                item.Selected = category.Id == product.CategoryId;
                list.Add(item);
            }
            ViewBag.categories = list;
            return View(product);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (product.Id > 0)
            {
                product = _productService.Update(product);
                
            }
            else
            {
                product = _productService.Add(product);
            }

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int productId)
        {
            var product = _productService.Get(productId);
            _productService.Delete(product);
            return RedirectToAction("Index");
        }

    }
}
