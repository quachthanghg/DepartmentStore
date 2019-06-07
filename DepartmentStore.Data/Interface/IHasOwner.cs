namespace DepartmentStore.Data.Interface
{
    public interface IHasOwner<T>
    {
        T OwnerId { get; set; }
    }
}