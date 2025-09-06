namespace Persistence.Postgres
{
    using Core.Aggregates.ProjectAggregate;
    using Core.Aggregates.UserAggregate;
    using Core.Aggregates.WorkItemAggregate;
    using Microsoft.EntityFrameworkCore;
    using Persistence.Postgres.Configuration;

    public class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Project> Projects => Set<Project>();
        public DbSet<WorkItem> WorkItems => Set<WorkItem>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new WorkItemConfiguration());

            // Seed data
            modelBuilder.Entity<User>().HasData(Seeds.UserSeed.GetUsers());
            modelBuilder.Entity<Project>().HasData(Seeds.ProjectSeed.GetProjects());
            modelBuilder.Entity<WorkItem>().HasData(Seeds.WorkItemSeed.GetWorkItems());
        }
    }
}
