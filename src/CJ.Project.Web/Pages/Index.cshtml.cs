using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace CJ.Project.Web.Pages
{
    public class IndexModel : ProjectPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}