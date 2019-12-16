using CJ.Project.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CJ.Project
{
    [DependsOn(
        typeof(ProjectEntityFrameworkCoreTestModule)
        )]
    public class ProjectDomainTestModule : AbpModule
    {

    }
}