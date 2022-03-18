using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GelAll();

        Category Get(int id);

        Category Add(Category category);

        Category Update(Category category);
        Category Delete(Category category);
    }
}
