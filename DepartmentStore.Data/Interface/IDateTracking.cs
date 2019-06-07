using System;

namespace DepartmentStore.Data.Interface
{
    public interface IDateTracking
    {
        DateTime CreateDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}