using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using CJ.Project.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CJ.Project.Web.Pages
{
    public abstract class ProjectPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<ProjectResource> L { get; set; }
    }
}
