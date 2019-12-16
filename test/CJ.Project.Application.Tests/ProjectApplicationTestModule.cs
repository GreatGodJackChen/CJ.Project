using Volo.Abp.Modularity;

namespace CJ.Project
{
    [DependsOn(
        typeof(ProjectApplicationModule),
        typeof(ProjectDomainTestModule)
        )]
    public class ProjectApplicationTestModule : AbpModule
    {

    }
}