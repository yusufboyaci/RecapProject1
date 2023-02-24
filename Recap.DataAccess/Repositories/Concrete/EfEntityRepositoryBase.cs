using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Recap.Core.Entity;
using Recap.Core.Enum;
using Recap.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recap.DataAccess.Repositories.Concrete
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : CoreEntity, new()
                                                                                        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                entity.Status = Status.Active;
                EntityEntry addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Add(List<TEntity> entities)
        {
            using (TContext context = new TContext())
            {
                foreach (TEntity item in entities)
                {
                    item.Status = Status.Active;
                    EntityEntry addedEntity = context.Entry(item);
                    addedEntity.State = EntityState.Added;
                }
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                entity.Status = Status.Deleted;
                EntityEntry deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public TEntity Get(Guid id)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                   context.Set<TEntity>().ToList() :
                   context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                entity.Status = Status.Updated;
                EntityEntry updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public bool Any(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Any(filter);
            }
        }
    }
}
