namespace persistence
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Npgsql;
    using Persistence.Postgres;
    using System;
    using System.Threading.Tasks;

    public class Setup
    {
        public static void AddPostgres(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                var connectionStringBuilder = new NpgsqlConnectionStringBuilder(configuration.GetConnectionString("ApplicationDb"))
                {
                    Database = "application_db"
                };

                options
                    .UseNpgsql(connectionStringBuilder.ConnectionString)
                    .EnableSensitiveDataLogging();
            });
        }

        public static async Task SeedPostgresAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();
        }
    }
}
