using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebSite.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            
            var categories = _categoryService.GelAll();


            return View(categories);
        }


        public IActionResult Delete(int categoryId)
        {
            var category = _categoryService.Get(categoryId);
            _categoryService.Delete(category);
            return RedirectToAction("Index");
        }

        public IActionResult Add(int categoryId=0)
        {
            var category = _categoryService.Get(categoryId);
            if (category == null)
            {
                category = new Category();
            }

            return View(category);
        }

        [HttpPost]

        public IActionResult Add(Category category)
        {
            if (category.Id > 0)
            {
                category = _categoryService.Update(category);
            }
            else
            {
                category = _categoryService.Add(category);
            }

            return RedirectToAction("Index");
        }
    }
}
