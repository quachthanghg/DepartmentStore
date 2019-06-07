using DepartmentStore.Data.Enums;
using DepartmentStore.Data.Interface;
using DepartmentStore.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentStore.Data.Entities
{
    [Table("Slides")]
    public class Slide : DomainEntity<int>, ISwitchable
    {
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Description { set; get; }

        [StringLength(250)]
        [Required]
        public string Image { set; get; }

        [StringLength(250)]
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }

        public Status Status { set; get; }

        public string Content { set; get; }

        [StringLength(25)]
        [Required]
        public string GroupAlias { get; set; }
    }
}