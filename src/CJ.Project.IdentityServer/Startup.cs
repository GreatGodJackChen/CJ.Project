using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CJ.Project
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<ProjectIdentityServerModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
