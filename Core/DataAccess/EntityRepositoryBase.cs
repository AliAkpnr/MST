using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using(TContext db = new TContext())
            {
                var addEntity = db.Entry(entity);
                addEntity.State = EntityState.Added;
                db.SaveChanges();
                return addEntity.Entity;
            }
        }

        public TEntity Delete(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var deleteEntity = db.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                db.SaveChanges();
                return deleteEntity.Entity;
            }
        }
        

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext db = new TContext())
            {
                return filter == null ? db.Set<TEntity>().ToList() : db.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var uEntity = db.Entry(entity);
                uEntity.State = EntityState.Modified;
                db.SaveChanges();
                return uEntity.Entity;
            }
        }
    }
}
