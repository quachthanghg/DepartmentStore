using DepartmentStore.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentStore.Data.Entities
{
    [Table("WholePrices")]
    public class WholePrice : DomainEntity<long>
    {
        public long ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}