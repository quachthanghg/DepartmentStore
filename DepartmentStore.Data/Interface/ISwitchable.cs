using DepartmentStore.Data.Enums;

namespace DepartmentStore.Data.Interface
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}