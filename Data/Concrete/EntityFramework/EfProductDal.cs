using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EntityRepositoryBase<Product,MSTContext>, IProductDal
    {
        public List<Product> GetAllByCategory(int categoryId)
        {
            return GetAll(p => p.CategoryId == categoryId);
        }

    }
}
