using Recap.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recap.DataAccess.Repositories.Abstract
{
    public interface IEntityRepository<T> where T : CoreEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>>? filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Get(Guid id);
        void Add(T entity);
        void Add(List<T> entities);
        void Update(T entity);
        void Delete(T entity);
        bool Any(Expression<Func<T, bool>> filter);
    }
}
