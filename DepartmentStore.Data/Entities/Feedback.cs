using DepartmentStore.Data.Enums;
using DepartmentStore.Data.Interface;
using DepartmentStore.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentStore.Data.Entities
{
    [Table("Feedbacks")]
    public class Feedback : DomainEntity<long>, ISwitchable, IDateTracking
    {
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(500)]
        public string Message { set; get; }

        public Status Status { set; get; }

        public DateTime CreateDate { set; get; }

        public DateTime? ModifiedDate { set; get; }
    }
}