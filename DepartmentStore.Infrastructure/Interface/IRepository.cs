using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DepartmentStore.Infrastructure.Interface
{
    public interface IRepository<TEntity, Key> where TEntity : class
    {
        TEntity FindById(Key id, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity FindSingle(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> FindAll(params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        void Remove(Key id);

        void RemoveMultiple(List<TEntity> entities);
    }
}