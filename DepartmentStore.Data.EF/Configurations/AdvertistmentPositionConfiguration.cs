using DepartmentStore.Data.EF.Extensions;
using DepartmentStore.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DepartmentStore.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
        }
    }
}