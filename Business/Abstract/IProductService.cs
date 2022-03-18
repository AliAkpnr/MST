using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetAllByCategoryId(int id);

        ///List<Product> GetByUnitPrice(decimal min, decimal max);

        Product Get(int id);

        Product Add(Product product);

        Product Update(Product product);
        Product Delete(Product product);
    }
}
