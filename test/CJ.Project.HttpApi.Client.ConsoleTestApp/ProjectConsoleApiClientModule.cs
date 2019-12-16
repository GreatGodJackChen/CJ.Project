using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CJ.Project.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ProjectHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ProjectConsoleApiClientModule : AbpModule
    {
        
    }
}
