using DepartmentStore.Infrastructure.Interface;

namespace DepartmentStore.Data.EF.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DepartmentStoreDbContext _departmentStoreDbContext;

        public UnitOfWork(DepartmentStoreDbContext departmentStoreDbContext)
        {
            _departmentStoreDbContext = departmentStoreDbContext;
        }

        public void Commit()
        {
            _departmentStoreDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _departmentStoreDbContext.Dispose();
        }
    }
}