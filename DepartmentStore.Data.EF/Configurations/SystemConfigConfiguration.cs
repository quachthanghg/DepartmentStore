using DepartmentStore.Data.EF.Extensions;
using DepartmentStore.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DepartmentStore.Data.EF.Configurations
{
    internal class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}