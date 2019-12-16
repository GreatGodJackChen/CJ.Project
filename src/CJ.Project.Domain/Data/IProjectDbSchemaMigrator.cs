using System.Threading.Tasks;

namespace CJ.Project.Data
{
    public interface IProjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
