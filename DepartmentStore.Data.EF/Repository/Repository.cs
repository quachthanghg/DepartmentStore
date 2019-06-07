using DepartmentStore.Infrastructure.Interface;
using DepartmentStore.Infrastructure.SharedKernel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DepartmentStore.Data.EF.Repository
{
    public class Repository<TEntity, Key> : IRepository<TEntity, Key>, IDisposable where TEntity : DomainEntity<Key>
    {
        private readonly DepartmentStoreDbContext _departmentStoreDbContext;

        public Repository(DepartmentStoreDbContext departmentStoreDbContext)
        {
            _departmentStoreDbContext = departmentStoreDbContext;
        }

        public void Add(TEntity entity)
        {
            _departmentStoreDbContext.Add(entity);
        }

        public void Dispose()
        {
            if (_departmentStoreDbContext != null)
            {
                _departmentStoreDbContext.Dispose();
            }
        }

        public IQueryable<TEntity> FindAll(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> items = _departmentStoreDbContext.Set<TEntity>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            return items;
        }

        public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> items = _departmentStoreDbContext.Set<TEntity>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            return items.Where(predicate);
        }

        public TEntity FindById(Key id, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(x => x.Id.Equals(id));
        }

        public TEntity FindSingle(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(predicate);
        }

        public void Remove(TEntity entity)
        {
            _departmentStoreDbContext.Set<TEntity>().Remove(entity);
        }

        public void Remove(Key id)
        {
            Remove(FindById(id));
        }

        public void RemoveMultiple(List<TEntity> entities)
        {
            _departmentStoreDbContext.Set<TEntity>().RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            _departmentStoreDbContext.Set<TEntity>().Update(entity);
        }
    }
}