using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace CJ.Project.Data
{
    public class ProjectDbMigrationService : ITransientDependency
    {
        public ILogger<ProjectDbMigrationService> Logger { get; set; }

        private readonly IDataSeeder _dataSeeder;
        private readonly IProjectDbSchemaMigrator _dbSchemaMigrator;

        public ProjectDbMigrationService(
            IDataSeeder dataSeeder,
            IProjectDbSchemaMigrator dbSchemaMigrator)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrator = dbSchemaMigrator;

            Logger = NullLogger<ProjectDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            Logger.LogInformation("Migrating database schema...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation("Executing database seed...");
            await _dataSeeder.SeedAsync();

            Logger.LogInformation("Successfully completed database migrations.");
        }
    }
}