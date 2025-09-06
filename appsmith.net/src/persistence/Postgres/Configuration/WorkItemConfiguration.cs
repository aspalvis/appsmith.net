namespace Persistence.Postgres.Configuration
{
    using Core.Aggregates.WorkItemAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class WorkItemConfiguration : IEntityTypeConfiguration<WorkItem>
    {
        public void Configure(EntityTypeBuilder<WorkItem> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Title).IsRequired();
            builder.Property(w => w.Description);
            builder.Property(w => w.ProjectId).IsRequired();
            builder.Property(w => w.AssigneeId).IsRequired();
        }
    }
}
