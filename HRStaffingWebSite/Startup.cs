using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRStaffingWebSite.Startup))]
namespace HRStaffingWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
