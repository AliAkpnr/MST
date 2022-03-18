using Business.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        public Category Delete(Category category)
        {
            return _categoryDal.Delete(category);
        }


        public List<Category> GelAll()
        {
            return _categoryDal.GetAll();
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }

        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }
    }
}
