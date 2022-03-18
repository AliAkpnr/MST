using System.Collections.Generic;
using Core.DataAccess;
using Core.Entities;
using Entities;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        
    }
}
