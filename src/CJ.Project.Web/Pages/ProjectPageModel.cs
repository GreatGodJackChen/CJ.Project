using CJ.Project.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CJ.Project.Web.Pages
{
    public abstract class ProjectPageModel : AbpPageModel
    {
        protected ProjectPageModel()
        {
            LocalizationResourceType = typeof(ProjectResource);
        }
    }
}