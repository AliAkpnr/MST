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
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product product)
        {

            return _productDal.Add(product);
        }

        public Product Delete(Product product)
        {
            return _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        //public List<Product> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        //}

        public Product Get(int id)
        {
            return _productDal.Get(x=> x.Id == id);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
