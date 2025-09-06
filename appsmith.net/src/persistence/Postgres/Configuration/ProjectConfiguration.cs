namespace Persistence.Postgres.Configuration
{
    using Core.Aggregates.ProjectAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description);
            builder.Property(p => p.WorkItemIds).HasColumnType("uuid[]");
        }
    }
}
