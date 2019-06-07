using System;

namespace DepartmentStore.Infrastructure.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// SaveChanges DbContext
        /// </summary>
        void Commit();
    }
}