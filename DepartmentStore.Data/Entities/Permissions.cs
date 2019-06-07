using DepartmentStore.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentStore.Data.Entities
{
    [Table("Permissions")]
    public class Permission : DomainEntity<int>
    {
        [StringLength(450)]
        [Required]
        public string RoleId { get; set; }

        [StringLength(128)]
        [Required]
        public string FunctionId { get; set; }

        public bool Create { set; get; }
        public bool Read { set; get; }

        public bool Update { set; get; }
        public bool Delete { set; get; }

        [ForeignKey("RoleId")]
        public virtual AppRole AppRole { get; set; }

        [ForeignKey("FunctionId")]
        public virtual Function Function { get; set; }
    }
}