using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CJ.Project.Data;
using Volo.Abp.DependencyInjection;

namespace CJ.Project.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreProjectDbSchemaMigrator 
        : IProjectDbSchemaMigrator, ITransientDependency
    {
        private readonly ProjectMigrationsDbContext _dbContext;

        public EntityFrameworkCoreProjectDbSchemaMigrator(ProjectMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}