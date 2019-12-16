using System;
using System.Collections.Generic;
using System.Text;
using CJ.Project.Localization;
using Volo.Abp.Application.Services;

namespace CJ.Project
{
    /* Inherit your application services from this class.
     */
    public abstract class ProjectAppService : ApplicationService
    {
        protected ProjectAppService()
        {
            LocalizationResource = typeof(ProjectResource);
        }
    }
}
