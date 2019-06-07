using DepartmentStore.Data.EF.Extensions;
using DepartmentStore.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DepartmentStore.Data.EF.Configurations
{
    public class PageConfiguration : DbEntityConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}