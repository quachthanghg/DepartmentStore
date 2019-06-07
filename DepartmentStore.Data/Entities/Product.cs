using DepartmentStore.Data.Enums;
using DepartmentStore.Data.Interface;
using DepartmentStore.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentStore.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<long>, IHasSeoMetadata, ISortable, ISwitchable, IDateTracking
    {
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        public long ProductCategoryId { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public string Content { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public decimal OriginalPrice { get; set; }

        public bool? HomeFlage { get; set; }

        public bool HotFlag { get; set; }

        public int ViewCount { get; set; }

        public string Unit { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Status Status { get; set; }

        public int SortOrder { get; set; }

        [StringLength(255)]
        public string SeoPageTitle { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        public string SeoAlias { get; set; }

        [StringLength(255)]
        public string SeoKeywords { get; set; }

        [StringLength(255)]
        public string SeoDescription { get; set; }

        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}