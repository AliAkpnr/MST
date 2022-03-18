using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal //: IProductDal
    {
        /*
        List<Product> _products;
        

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                //new Product{Id=1, CategoryId = 1, Name="Bardak", UnitPrice = 15, UnirsInStok = 15},
                //new Product{Id=2, CategoryId = 1, Name="Kamera", UnitPrice = 500, UnirsInStok = 16},
                //new Product{Id=3, CategoryId = 2, Name="Telefon", UnitPrice = 25, UnirsInStok= 5},
                //new Product{Id=4, CategoryId = 2, Name="Laptop", UnitPrice= 74, UnirsInStok = 37},
                //new Product{Id=5, CategoryId = 2, Name="TV", UnitPrice= 65, UnirsInStok = 98}

            };
        }



        List<Product> IEntityRepository<Product>.GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        Product IEntityRepository<Product>.Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        //Product IProductDal.Add(Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //Product IProductDal.Update(Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //Product IProductDal.Delete(Product product)
        //{
        //    throw new NotImplementedException();
        //}

        List<Product> IProductDal.GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        Product IEntityRepository<Product>.Add(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IEntityRepository<Product>.Update(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IEntityRepository<Product>.Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
          Product  productToDelete = _products.SingleOrDefault(p=>p.Id== product.Id);
          _products.Remove(productToDelete);

        }

        //List<Product> IProductDal.GetAll()
        //{
        //    return _products;
        //}

        //public void Update(Product product)
        //{
        //    Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
        //    productToUpdate.Name = product.Name;
        //    productToUpdate.CategoryId = product.CategoryId;
        //    productToUpdate.UnitPrice = product.UnitPrice;
        //    productToUpdate.UnirsInStok = product.UnirsInStok;
        //}

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
        */
    }
}